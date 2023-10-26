using eDentist.Model.Models;
using System;
using System.Collections.Generic;

namespace eDentist.Services.Database;

public partial class User
{
    public int UserId { get; set; }

    public string? Name { get; set; }

    public string? Surname { get; set; }

    public string? Email { get; set; }

    public string? Username { get; set; }
    public string PasswordHash { get;set; }
    public string PasswordSalt { get; set; }

    public string? Adress { get; set; }

    public string? ZipCode { get; set; }

    public int? CityId { get; set; }

    public virtual City? City { get; set; }

    public virtual ICollection<Favorite> Favorites { get; set; } = new List<Favorite>();

    public virtual ICollection<MedicalCard> MedicalCards { get; set; } = new List<MedicalCard>();

    public virtual ICollection<OrderHeader> OrderHeaders { get; set; } = new List<OrderHeader>();

    public virtual ICollection<UserRoles> UserRoles { get; } = new List<UserRoles>();
}
