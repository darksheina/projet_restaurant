using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProjectLibrary.Persistance
{
    public class RoleActionDAO
    {
        public int ID_role { get; set; }
        [Key, Column(Order = 0)]
        public virtual RoleDAO Role { get; set; }
        public int ID_action { get; set; }
        [Key, Column(Order = 1)]
        public virtual ActionDAO Action { get; set; }
    }
}
