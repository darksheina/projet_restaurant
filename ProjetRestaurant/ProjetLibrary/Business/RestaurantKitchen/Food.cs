using System;
namespace ProjectLibrary.Business.RestaurantKitchen
{
    public class Food
    {
        public int PreparationTime = 10000; // En millisec SVP
        public decimal price;
        public bool FoodCookStatus;
        public enum FoodType {entry, dish, dessert};
        public FoodType foodType;
    }
}
