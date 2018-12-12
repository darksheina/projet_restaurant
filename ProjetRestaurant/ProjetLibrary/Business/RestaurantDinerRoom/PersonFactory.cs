using System;
namespace ProjetLibrary.Business.RestaurantDinerRoom
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
        public static ProjectLibrary.Business.RestaurantKitchen.HeadChef CreateHeadChef()
        {
            throw new System.Exception("Not implemented");
        }
        public static ProjectLibrary.Business.RestaurantKitchen.Chef CreateChef()
        {
            throw new System.Exception("Not implemented");
        }
        public static ProjectLibrary.Business.RestaurantKitchen.AssistantCook CreateAssitantCook()
        {
            throw new System.Exception("Not implemented");
        }

    }

}