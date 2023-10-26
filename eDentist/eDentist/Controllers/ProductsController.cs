using eDentist.Model.Models;
using eDentist.Model.Requests;
using eDentist.Model.SearchObjects;
using eDentist.Services.Database;
using eDentist.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace eDentist.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [AllowAnonymous]
    public class ProductsController : BaseCrudController<ProductModel, ProductSearchObject, ProductInsertRequest, ProductUpdateRequest>
    {
        public ProductsController(ILogger<BaseController<ProductModel, ProductSearchObject>> logger, IProductService service) : base(logger,service)
        {

        }

        [HttpPut("{id}/activate")]
        public virtual async Task<ProductModel> Activate(int id)
        {
            return await (_service as IProductService).Activate(id);
        }

    }

}