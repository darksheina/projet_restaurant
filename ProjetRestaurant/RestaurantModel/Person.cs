using System;
namespace RestaurationModel {
    public abstract class Person {
        public string Name;
        public int ActiveTime;
        public int SleepyTime;

        private Kitchen.HeadChef headchef;
	private Kitchen.Chef chef;
        private DinerRoom.Buttler buttler;
        private DinerRoom.CustomerGroup customerGroup;
        private DinerRoom.Waiter waiter;
        private DinerRoom.Assistant assistant;
        private DinerRoom.HeadWaiter headWaiter;
        private Kitchen.AssistantCook assistantCook;

        private Scenario scenario;

    }
}
