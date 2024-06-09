using eDentist.Model.Models;
using eDentist.Model.Requests;
using eDentist.Model.SearchObjects;
using eDentist.Services.Interfaces;

namespace eDentist.Controllers
{
    public class CommentController : BaseCrudController<CommentModel, BaseSearchObject, CommentUpsertRequest, CommentUpsertRequest>
    {

        public CommentController(ICommentService service, ILogger<BaseController<CommentModel, BaseSearchObject>> logger) : base(logger, service)
        { }
    }
}
