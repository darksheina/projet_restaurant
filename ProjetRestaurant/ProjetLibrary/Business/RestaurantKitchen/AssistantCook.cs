using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectLibrary.Business.RestaurantKitchen
{
   public class AssistantCook
    {
        private readonly object assistantCookLock = new object();

        public Food PutFoodOnCounter()
        {
            lock (assistantCookLock)
            {
                // TODO : prendre le plat et le mettre dans la zone
                throw new System.Exception("Not implemented");
            }
            
        }

        public Food MakeFood()
        {
            throw new System.Exception("Not implemented");
        }
    }
}
