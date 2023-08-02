using eDentist.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace eDentist.Services
{
    public interface IProductService
    {
        IList<Products> GetProducts();
    }
}
