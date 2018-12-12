using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectLibrary.Business.RestaurantKitchen
{
    public class HeadChef 
    {
        public int TableIdOrder;
        public List<Food> GroupOrder;
        public List<string> TaskList;
        /*public void GetAnOrder(Waiter waiter)
        {
            this.TableIdOrder = waiter.CurrentTableIDOrder;
            foreach (Kitchen.Food food in waiter.currentGroupOrder)
            {
                this.groupOrder.Add(food);
            }
        }*/

        public void GiveTask(List<Food> groupOrder)
        {
            foreach (Food food in groupOrder)
            {
               /* if (food == Dish)
                {
                    
                }*/
            }
        }
    }
}
