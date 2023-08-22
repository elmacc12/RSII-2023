using eDentist.Model.Models;
using eDentist.Services.Database;
using eDentist.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eDentist.Services.Services
{
    public class ProductService : IProductService
    {
        EDentistDbContext _dbContext;
        public ProductService(EDentistDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        IList<Products> products = new List<Products>()
        {
            new Products()
            {
                ProductID= 1,
                ProductName="cetkica",
                ProductDescription="Jako korisna cetkica"
            }
        };
        public IList<Product> GetProducts()
        {
            var list = _dbContext.Products.ToList();
            return list;
        }
    }
}
