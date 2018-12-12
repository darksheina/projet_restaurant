using System;
namespace RestaurantDinerRoom
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
        public static RestaurantKitchen.Kitchen.HeadChef CreateHeadChef()
        {
            throw new System.Exception("Not implemented");
        }
        public static RestaurantKitchen.Kitchen.Chef CreateChef()
        {
            throw new System.Exception("Not implemented");
        }
        public static RestaurantKitchen.Kitchen.AssistantCook CreateAssitantCook()
        {
            throw new System.Exception("Not implemented");
        }

    }

}