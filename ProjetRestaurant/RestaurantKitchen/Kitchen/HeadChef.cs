using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantKitchen.Kitchen
{
    public class HeadChef 
    {
        public int TableIdOrder;
        public List<Food> groupOrder = new List<Food>();
        /*public void GetAnOrder(Waiter waiter)
        {
            this.TableIdOrder = waiter.CurrentTableIDOrder;
            foreach (Kitchen.Food food in waiter.currentGroupOrder)
            {
                this.groupOrder.Add(food);
            }
        }*/

        public void GiveTask()
        {

        }
    }
}
