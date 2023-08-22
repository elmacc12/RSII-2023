using eDentist.Model.Models;
using eDentist.Model.Requests;
using eDentist.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace eDentist.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CountryController:ControllerBase
    {

        private readonly ICountryService _service;
        public CountryController(ICountryService service)
        {
            _service = service;
        }

        [HttpPost]
        public CountryModel Insert(CountryInsertRequest c)
        {
            return _service.Insert(c);
        }
    }
}
