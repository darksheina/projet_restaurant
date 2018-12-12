using ProjectLibrary.Business;
using ProjectLibrary.Persistance;
using System.Collections.Generic;
using System.Linq;

namespace ProjectLibrary.Mapper
{
    class RoleActionMapper
    {
        //Tranform a RefersToBusiness
        public static RoleActionBusiness Map(RoleActionDAO refersto)
        {
            return new RoleActionBusiness
            {
                Action = refersto.Action != null ? ActionMapper.Map(refersto.Action) : null,
                Role = refersto.Role != null ? RoleMapper.Map(refersto.Role) : null,
            };
        }

        public static RoleActionDAO Map(RoleActionBusiness refersto)
        {
            return new RoleActionDAO
            {
                Action = refersto.Action != null ? ActionMapper.Map(refersto.Action) : null,
                Role = refersto.Role != null ? RoleMapper.Map(refersto.Role) : null,
            };
        }

        public static List<RoleActionBusiness> Map(List<RoleActionDAO> referstos)
        {
            return (from v in referstos select Map(v)).ToList();
        }
    }
}
