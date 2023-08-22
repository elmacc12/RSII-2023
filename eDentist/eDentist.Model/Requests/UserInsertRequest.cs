using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eDentist.Model.Requests
{
    public class UsersInsertRequest
    {

        public int? UserRole { get; set; }

        public string? Name { get; set; }

        public string? Surname { get; set; }

        public string? Email { get; set; }

        public string? Username { get; set; }

        public string? Password { get; set; }

        public string RepeatPassword { get; set; }

        public string? Adress { get; set; }

        public string? ZipCode { get; set; }

        public int? CityId { get; set; }
    }
}
