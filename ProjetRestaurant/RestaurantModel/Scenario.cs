using System;
namespace RestaurationModel
{
    public class Scenario
    {
        public int HeadChefNumber;
        public int ChefNumber;
        public int AssistantCookNumber;
        public int ButlerNumber;
        public int HeadWaiterNumber;
        public int WaiterNumber;
        public int AssistantNumber;
        public int NiceCustomerGroupNumber;
        public int HungryCustomerGroupNumber;
        public int NormalCustomerGroupNumber;
        public int TableNumber;
        public int SpeedTime;

        public void SelectScenario()
        {
            throw new System.Exception("Not implemented");
        }

        private Person person;
        private Table table;
        private Kitchen.Food food;

        private RestaurantModel restaurantModel;

    }
}
