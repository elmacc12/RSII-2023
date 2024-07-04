using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eDentist.Services.Interfaces
{
    public interface ISendMail
    {
        Task SendMailAsync(string email);
    }
}
