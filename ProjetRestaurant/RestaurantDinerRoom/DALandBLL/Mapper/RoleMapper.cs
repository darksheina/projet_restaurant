using RestaurantDinerRoom.DALandBLL.Business;
using RestaurantDinerRoom.DALandBLL.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestaurantDinerRoom.DALandBLL.Mapper
{
	public class RoleMapper {
       
            public static RoleBusiness Map(Persistance.RoleDAO role)
            {
                return new RoleBusiness
                {
                    ID = role.ID,
                    Entitled = role.Entitled,
                };
            }
            public static RoleDAO Map(Business.RoleBusiness role)
            {
                return new RoleDAO
                {
                    ID = role.ID,
                    Entitled = role.Entitled,
                };
            }
            public static List<RoleBusiness> Map(List<RoleDAO> roles)
            {
                return (from v in roles select Map(v)).ToList();
            }

        }
    }


