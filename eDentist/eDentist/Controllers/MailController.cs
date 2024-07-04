using eDentist.Model.Models;
using eDentist.Model.Requests;
using eDentist.Model.SearchObjects;
using eDentist.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace eDentist.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class MailController : ControllerBase
    {
        private readonly ISendMail _mail;
        public MailController(ISendMail mail)
        {
            _mail = mail;
        }

        [HttpGet()]
        public async Task SendMail(string mail)
        {
            await _mail.SendMailAsync(mail);
        }
    }
}

