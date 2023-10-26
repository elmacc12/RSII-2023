using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eDentist.Services.Database
{
    public class UserRoles
    {
        [Key]
        public int UserRoleID { get; set; }
        [ForeignKey("UserID")]
        public User User { get; set; }
        public int UserID { get; set; }
        [ForeignKey("RoleID")]
        public Roles Role { get; set; }
        public int RoleID { get; set; }
        public DateTime ChangedDate { get; set; }
    }
}
