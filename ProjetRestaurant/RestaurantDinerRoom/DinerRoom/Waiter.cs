using System;
using System.Collections.Generic;

namespace RestaurantDinerRoom.DinerRoom
{
    public class Waiter : Person
    {
        private int plateNumberMax = 5;
        public List<RestaurantKitchen.Kitchen.Food> currentGroupOrder = new List<RestaurantKitchen.Kitchen.Food>();
        public PersonStatus waiterStatus = PersonStatus.free;
        public int CurrentTableIDOrder;
        public int CurrentTableID;
        public int GetCurrentTableID()
        {
            return this.CurrentTableID;
        }
        public void SetCurrentTableID(int iDTable)
        {
            this.CurrentTableID = iDTable;
        }

        public void GetPlateOnCounter(int plateNumberMax)
        {
            throw new System.Exception("Not implemented");
        }
        public void GiveBread(int iDTable)
        {
            throw new System.Exception("Not implemented");
        }
        public void GiveWatter(int iDTable)
        {
            throw new System.Exception("Not implemented");
        }
        public void CleanTable(int iDTable, Table.TableStatus status)
        {
            throw new System.Exception("Not implemented");
        }
        public void GetOrdersFromGroup(CustomerGroup customerGroup)
        {
            if (this.CurrentTableID == customerGroup.IDTable)
            {
                this.CurrentTableIDOrder = this.CurrentTableID;
                for (int i = 0; i < customerGroup.GroupOrder.Count; i++)
                {
                    var food = customerGroup.GroupOrder[i];
                    currentGroupOrder.Add(food);
                }
            }
            else
            {
                Console.WriteLine("Waiter at the wrong Table");
            };
        }

        private Person person;

    }

}
