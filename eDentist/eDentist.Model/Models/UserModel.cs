﻿using eDentist.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eDentist.Model
{
    public class UserModel
    {
        public int UserId { get; set; }

        public int? UserRole { get; set; }

        public string? Name { get; set; }

        public string? Surname { get; set; }

        public string? Email { get; set; }

        public string? Username { get; set; }

        public string? Adress { get; set; }

        public string? ZipCode { get; set; }

        public int? CityId { get; set; }
        public virtual ICollection<UserRolesModel> UserRoles { get; } = new List<UserRolesModel>();
    }
}
