using ProjetLibrary.Business.RestaurantDinerRoom;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ProjectLibrary.Business.RestaurantKitchen
{
    public class Chef : Person
    {
        public List<Food> FooDReady = new List<Food>();
        public Chef()
        {//A modifier
            this.Name = "Chef";
            this.PersonIsBusy = false;
        }
        public List<Food> MakeFood(List<Food> customerOrders, string task)
        {
            foreach (Food food in customerOrders) // TO DO some Tests 
            {
                if (food.FoodCookStatus == false)
                {
                    if (task == "entry" && food.foodType == Food.FoodType.entry)
                    {
                        this.PersonIsBusy = true;
                        Thread.Sleep(food.PreparationTime);
                        food.FoodCookStatus = true;
                        this.FooDReady.Add(food);
                        //customerOrders.Remove(food);
                    }
                    else if (task == "dish" && food.foodType == Food.FoodType.dish)
                    {
                        this.PersonIsBusy = true;
                        Thread.Sleep(food.PreparationTime);
                        food.FoodCookStatus = true;
                        this.FooDReady.Add(food);
                        // customerOrders.Remove(food);
                    }
                    else if (task == "dessert" && food.foodType == Food.FoodType.dessert)
                    {
                        this.PersonIsBusy = true;
                        Thread.Sleep(food.PreparationTime);
                        food.FoodCookStatus = true;
                        this.FooDReady.Add(food);
                        // customerOrders.Remove(food);
                    }
                }
            }
            this.PersonIsBusy = false;
            return FooDReady;
        }
    }
}
