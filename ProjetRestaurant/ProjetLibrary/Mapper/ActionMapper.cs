using ProjectLibrary.Business;
using System.Collections.Generic;
using System.Linq;

namespace ProjectLibrary.Mapper
{
    public class ActionMapper
    {
        //Tranform a ActionDAO object into a ActionBusiness object
        public static ActionBusiness Map(ProjetLibrary.Persistance.Action action)
        {
            return new ActionBusiness
            {
                ID = action.ID,
                Entitled = action.Entitled,
                MethodRef = action.MethodRef
            };
        }
        //Tranform a ActionBusiness object into a ActionDAO object
        public static ProjetLibrary.Persistance.Action Map(ActionBusiness action)
        {

            return new ProjetLibrary.Persistance.Action
            {
                ID = action.ID,
                Entitled = action.Entitled,
                MethodRef = action.MethodRef

            };

        }
        //Tranform a list of ActionDAO object into a list of ActionBusiness object
        public static List<ActionBusiness> Map(List<ProjetLibrary.Persistance.Action> action)
        {
            return (from v in action select Map(v)).ToList();

        }

    }
}
