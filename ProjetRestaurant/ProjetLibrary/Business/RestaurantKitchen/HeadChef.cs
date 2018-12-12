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

        public void GiveTask(List<Food> groupOrder, Chef chef, AssistantCook assistantCook )
        {
           foreach(Food food in groupOrder)
           {
                if (food.foodType == Food.FoodType.entry)
                {

                }
           }
           if(chef.PersonIsBusy == false)
           {
                
           }
           else if(assistantCook.PersonIsBusy == false)
           {

           }
           else
           {
                Thread.Sleep(5000);
           };
        }
    }
}
