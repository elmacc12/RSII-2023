﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eDentist.Model.Models
{
    public class RecommendResultModel
    {
        public int Id { get; set; }

        public int? ProizvodId { get; set; }

        public int? PrviProizvodId { get; set; }

        public int? DrugiProizvodId { get; set; }

        public int? TreciProizvodId { get; set; }
    }
}
