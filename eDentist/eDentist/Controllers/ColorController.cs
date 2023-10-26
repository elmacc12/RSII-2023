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
    public class ColorController: BaseCrudController<ColorModel, BaseSearchObject, ColorInsertRequest, ColorUpdateRequest>
    {
        public ColorController(IColorService service, ILogger<BaseController<ColorModel, BaseSearchObject>> logger) : base(logger, service)
        {
        }
    }
}
