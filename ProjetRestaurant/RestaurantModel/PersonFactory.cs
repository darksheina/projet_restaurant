using System;
namespace RestaurationModel
{
    public abstract class PersonFactory
    {
        public static DinerRoom.CustomerGroup CreateCustomer()
        {
            throw new System.Exception("Not implemented");
        }
        public static DinerRoom.Buttler CreateButler()
        {
            throw new System.Exception("Not implemented");
        }
        public static DinerRoom.HeadWaiter CreateHeadWaiter()
        {
            throw new System.Exception("Not implemented");
        }
        public static DinerRoom.Waiter CreateWaiter()
        {
            throw new System.Exception("Not implemented");
        }
        public static DinerRoom.Assistant CreateAssistant()
        {
            throw new System.Exception("Not implemented");
        }
        public static Kitchen.HeadChef CreateHeadChef()
        {
            throw new System.Exception("Not implemented");
        }
        public static Kitchen.Chef CreateChef()
        {
            throw new System.Exception("Not implemented");
        }
        public static Kitchen.AssistantCook CreateAssitantCook()
        {
            throw new System.Exception("Not implemented");
        }

    }

}