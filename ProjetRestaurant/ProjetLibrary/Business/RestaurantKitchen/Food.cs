using System;
namespace ProjectLibrary.Business.RestaurantKitchen
{
    public class Food
    {
        public int PreparationTime; // En milliseconde pour les Thread.Sleep de MakeFood() 
        public decimal Price;
        public bool FoodCookStatus;
        public enum FoodType { entry, dish, dessert };
        public FoodType foodType;

        public Food(FoodType foodType, decimal price)
        {
            this.foodType = foodType;
            if (foodType == FoodType.entry)
            {
                this.PreparationTime = 8000; // Temps en milliseconde
            }
            else if (foodType == FoodType.dish)
            {
                this.PreparationTime = 15000;  // Temps en milliseconde
            }
            else if (foodType == FoodType.dish)
            {
                this.PreparationTime = 10000;  // Temps en milliseconde
            }
            this.FoodCookStatus = false;
            this.Price = price;
        }
    }
}
