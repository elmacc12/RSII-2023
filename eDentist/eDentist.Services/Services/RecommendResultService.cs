using AutoMapper;
using eDentist.Model.Requests;
using eDentist.Model.SearchObjects;
using eDentist.Services.Interfaces;
using Microsoft.ML.Data;
using Microsoft.ML.Trainers;
using Microsoft.ML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eDentist.Model.Models;
using eDentist.Services.Database;
using Microsoft.EntityFrameworkCore;

namespace eDentist.Services.Services
{
    public class RecommendResultService : BaseCrudService<RecommendResultModel, RecommendResult, BaseSearchObject, RecommendResultUpsertRequest, RecommendResultUpsertRequest>, IRecommendResultService
    {
        public RecommendResultService(EDentistDbContext context, IMapper mapper)
          : base(context, mapper)
        {
        }

        static MLContext mlContext = null;
        static object isLocked = new object();
        static ITransformer modeltr = null;



        public List<ProductModel> Recommend(int? id)
        {
            lock (isLocked)
            {
                if (mlContext == null)
                {
                    mlContext = new MLContext();

                    var tmpData = _context.OrderHeaders.Include("OrderOrderHeaders").ToList();

                    var data = new List<RatingEntry>();

                    foreach (var x in tmpData)
                    {
                        if (x.OrderOrderHeaders.Count > 1)
                        {
                            var distinctItemId = x.OrderOrderHeaders.Select(y => y.ProductId).ToList();

                            distinctItemId.ForEach(y =>
                            {
                                var relatedItems = x.OrderOrderHeaders.Where(z => z.ProductId != y).ToList();

                                foreach (var z in relatedItems)
                                {
                                    data.Add(new RatingEntry()
                                    {
                                        RatingId = (uint)y,
                                        CoRatingId = (uint)z.ProductId,
                                    });
                                }
                            });
                        }
                    }
                    var traindata = mlContext.Data.LoadFromEnumerable(data);
                    MatrixFactorizationTrainer.Options options = new MatrixFactorizationTrainer.Options();
                    options.MatrixColumnIndexColumnName = nameof(RatingEntry.RatingId);
                    options.MatrixRowIndexColumnName = nameof(RatingEntry.CoRatingId);
                    options.LabelColumnName = "Label";
                    options.LossFunction = MatrixFactorizationTrainer.LossFunctionType.SquareLossOneClass;
                    options.Alpha = 0.01;
                    options.Lambda = 0.025;
                    options.NumberOfIterations = 100;
                    options.C = 0.00001;

                    var est = mlContext.Recommendation().Trainers.MatrixFactorization(options);

                    modeltr = est.Fit(traindata);
                }
            }

            var allItems = _context.Products.Where(x => x.ProductId != id);
            var predictionResult = new List<Tuple<Database.Product, float>>();

            foreach (var item in allItems)
            {
                var predictionEngine = mlContext.Model.CreatePredictionEngine<RatingEntry, Copurchase_prediction>(modeltr);
                var prediction = predictionEngine.Predict(new RatingEntry()
                {
                    RatingId = (uint)id,
                    CoRatingId = (uint)item.ProductId
                });

                predictionResult.Add(new Tuple<Database.Product, float>(item, prediction.Score));
            }
            var finalResult = predictionResult.OrderByDescending(x => x.Item2).Select(x => x.Item1).Take(3).ToList();

            if (finalResult != null)
                return _mapper.Map<List<ProductModel>>(finalResult);
            return null;
        }

        public class RatingEntry
        {
            [KeyType(count: 262111)]
            public uint RatingId { get; set; }
            [KeyType(count: 262111)]
            public uint CoRatingId { get; set; }
            public float Label { get; set; }

        }
        public class Copurchase_prediction
        {
            public float Score { get; set; }
        }

        public async Task<List<RecommendResultModel>> TrainProductsModel()
        {
            var stavkeNarudzbe = _context.OrderHeaders.ToList();
            var proizvodi = _context.Products.ToList();

            if (proizvodi.Count > 4 && stavkeNarudzbe.Count() > 2)
            {
                List<Database.RecommendResult> recommendList = new List<Database.RecommendResult>();

                foreach (var proizvod in proizvodi)
                {

                    var recommendedProducts = Recommend(proizvod.ProductId);


                    var resultRecommend = new Database.RecommendResult()
                    {
                        ProizvodId = proizvod.ProductId,
                        PrviProizvodId = recommendedProducts[0].ProductId,
                        DrugiProizvodId = recommendedProducts[1].ProductId,
                        TreciProizvodId = recommendedProducts[2].ProductId,
                    };
                    recommendList.Add(resultRecommend);
                }

                var list = _context.RecommendResult.ToList();
                var recordCount = list.Count();
                var proizvodiCount = _context.Products.Count();
                if (recordCount != 0)
                {
                    if (recordCount > proizvodiCount)
                    {
                        for (int i = 0; i < proizvodiCount; i++)
                        {
                            list[i].ProizvodId = recommendList[i].ProizvodId;
                            list[i].PrviProizvodId = recommendList[i].PrviProizvodId;
                            list[i].DrugiProizvodId = recommendList[i].DrugiProizvodId;
                            list[i].TreciProizvodId = recommendList[i].TreciProizvodId;
                        }

                        for (int i = proizvodiCount; i < recordCount; i++)
                        {
                            _context.RecommendResult.Remove(list[i]);
                        }
                    }
                    else
                    {
                        for (int i = 0; i < recordCount; i++)
                        {
                            list[i].ProizvodId = recommendList[i].ProizvodId;
                            list[i].PrviProizvodId = recommendList[i].PrviProizvodId;
                            list[i].DrugiProizvodId = recommendList[i].DrugiProizvodId;
                            list[i].TreciProizvodId = recommendList[i].TreciProizvodId;
                        }
                        var num = recommendList.Count() - recordCount;

                        if (num > 0)
                        {
                            for (int i = recommendList.Count() - num; i < recommendList.Count(); i++)
                            {
                                _context.RecommendResult.Add(recommendList[i]);
                            }
                        }
                    }
                }
                else
                {
                    _context.RecommendResult.AddRange(recommendList);
                }
                await _context.SaveChangesAsync();
                return _mapper.Map<List<RecommendResultModel>>(recommendList);
            }
            else
            {
                throw new Exception("Not enough data to do recommmedation");
            }
        }

        public Task DeleteAllRecommendation()
        {
            return _context.RecommendResult.ExecuteDeleteAsync();
        }


    }
}
