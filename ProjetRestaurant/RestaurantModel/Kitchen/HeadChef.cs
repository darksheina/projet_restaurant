using RestaurationModel.DinerRoom;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurationModel.Kitchen
{
    public class HeadChef : Person
    {
        public int TableIdOrder;
        public List<Food> groupOrder = new List<Food>();
        public void GetAnOrder(Waiter waiter)
        {
            this.TableIdOrder = waiter.CurrentTableIDOrder;
            foreach (Kitchen.Food food in waiter.currentGroupOrder)
            {
                this.groupOrder.Add(food);
            }
        }

        public void GiveTask()
        {

        }
    }
}
