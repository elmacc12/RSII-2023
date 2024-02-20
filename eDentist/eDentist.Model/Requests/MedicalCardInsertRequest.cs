﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eDentist.Model.Requests
{
    public class MedicalCardInsertRequest
    {
        public int? UserId { get; set; }

        public int? DentalServiceId { get; set; }
        public DateTime datumDijagnoze { get; set; }

        public string? DoctorsOppinion { get; set; }
    }
}
