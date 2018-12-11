using RestaurationModel.DALandBLL.Business;
using RestaurationModel.DALandBLL.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestaurationModel.DALandBLL.Mapper
{
    class RefersToMapper
    {
        public static RefersToBusiness Map(RefersToDAO refersto)
        {
            return new RefersToBusiness
            {
                Action = refersto.Action != null ? ActionMapper.Map(refersto.Action) : null,
                Role = refersto.Role != null ? RoleMapper.Map(refersto.Role) : null,
            };
        }

        public static RefersToDAO Map(RefersToBusiness refersto)
        {
            return new RefersToDAO
            {
                Action = refersto.Action != null ? ActionMapper.Map(refersto.Action) : null,
                Role = refersto.Role != null ? RoleMapper.Map(refersto.Role) : null,
            };
        }

        public static List<RefersToBusiness> Map(List<RefersToDAO> referstos)
        {
            return (from v in referstos select Map(v)).ToList();
        }
    }
}
