﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eDentist.Model.Models
{
    public class Products
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public byte[] Image { get; set; }
        public byte[] ImageThumb { get; set; }

    }
}
