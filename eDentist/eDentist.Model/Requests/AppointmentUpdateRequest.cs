using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eDentist.Model.Requests
{
    public class AppointmentUpdateRequest
    {
        public int AppointmentID { get; set; }
        public int UserId { get; set; }
        public DateTime Datum { get; set; }
        public string Vrijeme { get; set; }
        public bool TerminZatvoren { get; set; }
    }
}
