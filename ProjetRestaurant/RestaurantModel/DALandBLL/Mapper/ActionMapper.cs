using RestaurationModel.DALandBLL.Business;
using RestaurationModel.DALandBLL.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestaurationModel.DALandBLL.Mapper
{
    public class ActionMapper
    {
        public static ActionBusiness Map(ActionDAO action)
        {
            return new ActionBusiness
            {
                ID = action.ID,
                Entitled = action.Entitled,
                MethodRef = action.MethodRef
            };
        }
        public static ActionDAO Map(ActionBusiness action)
        {

            return new ActionDAO
            {
                ID = action.ID,
                Entitled = action.Entitled,
                MethodRef = action.MethodRef

            };

        }
        public static List<ActionBusiness> Map(List<ActionDAO> action)
        {
            return (from v in action select Map(v)).ToList();

        }

    }
}
