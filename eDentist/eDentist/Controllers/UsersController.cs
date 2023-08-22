using eDentist.Model;
using eDentist.Services.Database;
using eDentist.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace eDentist.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IUsersService _service;
        public UsersController(IUsersService service)
        {
            _service = service;
        }

        [HttpGet]
        public IEnumerable<UserModel> Get()
        {
            return _service.Get();
        }

    }
}
