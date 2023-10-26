using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eDentist.Model.Models
{
    public class UserRolesModel
    {
        public int UserRoleID { get; set; }
        public RolesModel Role { get; set; }
        public DateTime ChangedDate { get; set; }
    }
}
