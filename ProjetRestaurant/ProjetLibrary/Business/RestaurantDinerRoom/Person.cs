using System;
namespace ProjetLibrary.Business.RestaurantDinerRoom {
    public abstract class Person {
        public string Name;
        public int ActiveTime;
        public int SleepyTime;

        private ProjectLibrary.Business.RestaurantKitchen.HeadChef headchef;
        public enum PersonStatus { busy, free };
        private ProjectLibrary.Business.RestaurantKitchen.Chef chef;
        private DinerRoom.Buttler buttler;
        private DinerRoom.CustomerGroup customerGroup;
        private DinerRoom.Waiter waiter;
        private DinerRoom.Assistant assistant;
        private DinerRoom.HeadWaiter headWaiter;
        private ProjectLibrary.Business.RestaurantKitchen.AssistantCook assistantCook;

        private Scenario scenario;

    }
}
