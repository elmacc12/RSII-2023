using eDentist.Model;
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
    public class UsersController : BaseCrudController<UserModel, UsersSearchObject, UsersInsertRequest, UserUpdateRequest>
    {
        public UsersController(ILogger<BaseController<UserModel, UsersSearchObject>> logger, IUsersService service) : base(logger,service)
        {

        }


    }
}
