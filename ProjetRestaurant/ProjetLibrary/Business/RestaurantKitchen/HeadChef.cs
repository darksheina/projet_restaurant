using ProjetLibrary.Business.RestaurantDinerRoom;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ProjectLibrary.Business.RestaurantKitchen
{
    public class HeadChef : Person
    {
        public int TableIdOrder;
        public List<Food> GroupOrder;
        public List<Food> FooDReady = new List<Food>();
        public string TaskEntry = "entry";
        public string TaskDish = "dish";
        public string TaskDessert = "dessert";
        public HeadChef()
        {   //A modifier
            this.Name = "headChef";
            this.PersonIsBusy = false;
        }
        public void GetAnOrder()
        {   //Ecoute du socket
            throw new System.Exception("Not implemented");
        }

        public void GiveTask(List<Food> groupOrder, Chef chef, AssistantCook assistantCook)
        {
            foreach (Food food in groupOrder)
            {
                if (food.foodType == Food.FoodType.entry)
                {
                    if (food.FoodCookStatus == false)
                    {
                        while (chef.PersonIsBusy != false && assistantCook.PersonIsBusy != false)
                        {
                            this.PersonIsBusy = true;
                        }
                        if (chef.PersonIsBusy == false)
                        {
                            this.FooDReady = chef.MakeFood(groupOrder, TaskEntry);

                            this.PersonIsBusy = false;
                        }
                        else if (assistantCook.PersonIsBusy == false)
                        {
                            this.FooDReady = assistantCook.MakeFood(groupOrder, TaskEntry);
                            this.PersonIsBusy = false;
                        }
                    }
                }
                if (food.foodType == Food.FoodType.dish)
                {
                    if (food.FoodCookStatus == false)
                    {
                        while (chef.PersonIsBusy != false && assistantCook.PersonIsBusy != false)
                        {
                            this.PersonIsBusy = true;
                        }
                        if (chef.PersonIsBusy == false)
                        {
                            this.FooDReady = chef.MakeFood(groupOrder, TaskDish);
                            this.PersonIsBusy = false;
                        }
                        else if (assistantCook.PersonIsBusy == false)
                        {
                            this.FooDReady = assistantCook.MakeFood(groupOrder, TaskDish);
                            this.PersonIsBusy = false;
                        }
                    }
                }
                if (food.foodType == Food.FoodType.dessert)
                {
                    if (food.FoodCookStatus == false)
                    {
                        while (chef.PersonIsBusy != false && assistantCook.PersonIsBusy != false)
                        {
                            this.PersonIsBusy = true;
                        }
                        if (chef.PersonIsBusy == false)
                        {
                            this.FooDReady = chef.MakeFood(groupOrder, TaskDessert);
                            this.PersonIsBusy = false;
                        }
                        else if (assistantCook.PersonIsBusy == false)
                        {
                            this.FooDReady = assistantCook.MakeFood(groupOrder, TaskDessert);
                            this.PersonIsBusy = false;
                        }
                    }
                }
            }
        }
    }
}