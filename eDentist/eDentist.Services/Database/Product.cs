using System;
using System.Collections.Generic;

namespace eDentist.Services.Database;

public partial class Product
{
    public int ProductId { get; set; }

    public string? ProductName { get; set; }

    public string? ProductDescription { get; set; }

    public int? ProductPrice { get; set; }

    public int? QuantityLeft { get; set; }

    public int? ProductTypeId { get; set; }

    public int? ProductColorId { get; set; }

    public virtual ICollection<Favorite> Favorites { get; set; } = new List<Favorite>();

    public virtual Color? ProductColor { get; set; }

    public virtual ProductType? ProductType { get; set; }
}
