﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eDentist.Model.Requests
{
    public class ProductInsertRequest
    {

        public int ProductId { get; set; }

        [Required(AllowEmptyStrings =false)]
        public string? ProductName { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string? ProductDescription { get; set; }

        [Required]
        [Range(0,10000)]
        public int? ProductPrice { get; set; }

        public int? QuantityLeft { get; set; }

        public int? ProductTypeId { get; set; }
        public int ColorID { get; set; }
    }
}
