﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eDentist.Model.Requests
{
    public class ColorUpdateRequest
    {
        public int ColorId { get; set; }

        public string? ColorName { get; set; }

    }
}
