﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eDentist.Model.Requests
{
    public class ProductTypeInsertRequest
    {
        public int TypeId { get; set; }

        public string? TypeName { get; set; }
    }
}
