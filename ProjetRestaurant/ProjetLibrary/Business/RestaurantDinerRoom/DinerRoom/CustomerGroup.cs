using System;
using System.Collections.Generic;
using System.Threading;

namespace ProjetLibrary.Business.RestaurantDinerRoom.DinerRoom
{
    public class CustomerGroup : Person
    {
        public int GroupNumber;
        public List<ProjectLibrary.Business.RestaurantKitchen.Food> GroupOrder = new List<ProjectLibrary.Business.RestaurantKitchen.Food>();
        public int IDTable;
        public int GroupID;
        public EatStategy EatStrategy;

        public CustomerGroup() { }
        public CustomerGroup(int groupNumber, int iDTable, int groupID)
        {
            this.GroupNumber = groupNumber;
            this.IDTable = iDTable;
            this.GroupID = groupID;
        }
        public void CallWaiter(List<Waiter> waiterList)
        {
            Waiter activeWaiter = null;
            for (int i = 0; i < waiterList.Count; i++)
            {
                if (waiterList[i].waiterStatus == PersonStatus.free) //Check la liste des Waiter pour call celui dispo
                {
                    activeWaiter = waiterList[i];
                    activeWaiter.SetCurrentTableID(this.IDTable);
                    activeWaiter.waiterStatus = PersonStatus.busy;
                    Console.WriteLine("SUCCESS : Waiter CALLED");
                    break;
                }
                else if (activeWaiter == null && i == waiterList.Count) // Aucun waiter de dispo
                { //TO DO un WAIT de 5 sec et relancer la recherche de Waiter dispo?
                    Console.WriteLine("All waiter are busy, Customer Group wait 5 to call again");
                }
            }
        }
        public void AskBread()
        {
            throw new System.Exception("Not implemented");
        }
        public void AskWater()
        {
            throw new System.Exception("Not implemented");
        }
        public void Eat()
        {
            throw new System.Exception("Not implemented");
        }
        public int GetGroupNumber()
        {
            return this.GroupNumber;
        }
        public void SetGroupNumber()
        {
             Random rnd = new Random();
             int groupNumber = rnd.Next(1, 9);
             Console.WriteLine(groupNumber);
             this.GroupNumber = groupNumber;
        }
        public int GetGroupID()
        {
            return this.GroupID;
        }
        public void SetGroupIDTable(Table table)
        {
            this.IDTable = table.IDTable;
        }
        public int GetGroupIDTable()
        {
            return this.IDTable;
        }
        public void SetGroupID(int groupID)
        {
            this.GroupID = groupID;
        }
        public List<ProjectLibrary.Business.RestaurantKitchen.Food> GetGroupOrder()
        {
            return this.GroupOrder;
        }
        public void SetGroupOrder(List<ProjectLibrary.Business.RestaurantKitchen.Food> groupOrder)
        {
            foreach(ProjectLibrary.Business.RestaurantKitchen.Food food in groupOrder){
                this.GroupOrder.Add(food);
            }
        }

        public void ChooseOrder()
         {
             // TODO : modifier ?
             // Le client choisi son plat, il met au moins 5 min
             Console.WriteLine("CustomerGroup : Il nous faut au moins 5 min pour choisir nos plats !!"); // TODO : a enlever --> log
             Thread.Sleep(5000); //wait 5sec for choose order
             Console.WriteLine("CustomerGroup : Nous avons choisi nos plats !!"); // TODO : a enlever --> log
         }

        private EatStategy eatStategy;
        private Person person;
    }

}