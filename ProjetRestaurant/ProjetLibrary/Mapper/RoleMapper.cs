
using ProjetLibrary.Business;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjetLibrary.Mapper
{
	public class RoleMapper {
       
            public static RoleBusiness Map(ProjetLibrary.Persistance.Role role)
            {
                return new RoleBusiness
                {
                    ID = role.ID,
                    Entitled = role.Entitled,
                };
            }
            public static ProjetLibrary.Persistance.Role Map(Business.RoleBusiness role)
            {
                return new ProjetLibrary.Persistance.Role
                {
                    ID = role.ID,
                    Entitled = role.Entitled,
                };
            }
            public static List<RoleBusiness> Map(List<ProjetLibrary.Persistance.Role> roles)
            {
                return (from v in roles select Map(v)).ToList();
            }

        }
    }


