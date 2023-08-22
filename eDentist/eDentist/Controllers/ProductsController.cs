using eDentist.Services.Database;
using eDentist.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace eDentist.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        private readonly ILogger<WeatherForecastController> _logger;

        public ProductsController(ILogger<WeatherForecastController> logger, IProductService productService)
        {
            _logger = logger;
            _productService = productService;
        }

        [HttpGet()]
        public IEnumerable<Product> Get()
        {
            return _productService.GetProducts();
        }
    }
}