using eDentist.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eDentist.Services
{
    public class ProductService : IProductService
    {
        IList<Products> products = new List<Products>()
        {
            new Products()
            {
                ProductID= 1,
                ProductName="cetkica",
                ProductDescription="Jako korisna cetkica"
            }
        };
        public IList<Products> GetProducts()
        {
            return products;
        }
    }
}
