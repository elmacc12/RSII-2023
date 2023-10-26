using System;
using System.Collections.Generic;
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

        public string? ProductName { get; set; }

        public string? ProductDescription { get; set; }

        public int? ProductPrice { get; set; }

        public int? QuantityLeft { get; set; }

        public int? ProductTypeId { get; set; }
        public int ColorID { get; set; }
    }
}
