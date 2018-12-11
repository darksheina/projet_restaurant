using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RestaurationModel.DALandBLL.Persistance
{
    public class RefersToDAO
    {
        public int ID_role { get; set; }
        [Key]
        public virtual RoleDAO Role { get; set; }
        public int ID_action { get; set; }
        [Key]
        public virtual ActionDAO Action { get; set; }
    }
}
