using System;
using System.Collections.Generic;
using System.Threading;

namespace ProjetLibrary.Business.RestaurantDinerRoom.DinerRoom
{
    public class Waiter : Person
    {
        private int plateNumberMax = 5;
        public List<ProjectLibrary.Business.RestaurantKitchen.Food> currentGroupOrder = new List<ProjectLibrary.Business.RestaurantKitchen.Food>();
        public int CurrentTableIDOrder;
        public int CurrentTableID;
        public Waiter()
        {//A MODIFIER
            this.Name = "waiter";
            this.PersonIsBusy = false;
        }
        public int GetCurrentTableID()
        {
            return this.CurrentTableID;
        }
        public void SetCurrentTableID(int iDTable)
        {
            this.CurrentTableID = iDTable;
        }

        public void GetPlateOnCounter()
        {
            //Get plate from Socket
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
        public void CleanTable(Table table)
        {
            if(table.status == Table.TableStatus.dirty)
            {
                table.status = Table.TableStatus.free;
                Thread.Sleep(2000);
            }
            else if (table.status != Table.TableStatus.dirty)
            {
                Console.WriteLine("Waiter : Table not dirty...");
            }
            else
            {
                Console.WriteLine("Waiter : Can't clean");
            };
        }
        public void GetOrdersFromGroup(CustomerGroup customerGroup)
        {
                this.CurrentTableIDOrder = this.CurrentTableID;
                for (int i = 0; i < customerGroup.GroupOrder.Count; i++)
                {
                    var food = customerGroup.GroupOrder[i];
                    currentGroupOrder.Add(food);
                }
        }
        public void GiveOrderToKitchen()
        {

        }
        private Person person;

    }

}
