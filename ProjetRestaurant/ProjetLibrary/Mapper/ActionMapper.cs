using ProjectLibrary.Business;
using ProjectLibrary.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectLibrary.Mapper
{
    public class ActionMapper
    {
        //Tranform a ActionDAO object into a ActionBusiness object
        public static ActionBusiness Map(ActionDAO action)
        {
            return new ActionBusiness
            {
                ID = action.ID,
                Entitled = action.Entitled,
                MethodRef = action.MethodRef
            };
        }
        //Tranform a ActionBusiness object into a ActionDAO object
        public static ActionDAO Map(ActionBusiness action)
        {

            return new ActionDAO
            {
                ID = action.ID,
                Entitled = action.Entitled,
                MethodRef = action.MethodRef

            };

        }
        //Tranform a list of ActionDAO object into a list of ActionBusiness object
        public static List<ActionBusiness> Map(List<ActionDAO> action)
        {
            return (from v in action select Map(v)).ToList();

        }

    }
}
