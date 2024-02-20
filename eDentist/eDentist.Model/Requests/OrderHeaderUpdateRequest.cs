﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eDentist.Model.Requests
{
    public class OrderHeaderUpdateRequest
    {
        public DateTime? OrderDate { get; set; }

        public int? UserId { get; set; }

        public int? TotalPrice { get; set; }
    }
}
