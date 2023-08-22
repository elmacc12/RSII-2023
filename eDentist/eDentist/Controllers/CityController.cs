using eDentist.Model.Models;
using eDentist.Model.Requests;
using eDentist.Model.SearchObjects;
using eDentist.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace eDentist.Controllers
{
    [ApiController]
    [AllowAnonymous]
    public class CityController : BaseController<CityModel,CitySearch>
    {
        public CityController(ICityService service, ILogger<BaseController<CityModel,CitySearch>> logger) : base(service, logger)
        {
        }
    }
}
