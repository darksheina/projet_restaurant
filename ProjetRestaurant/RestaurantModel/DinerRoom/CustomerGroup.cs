using System;
<<<<<<< HEAD
using System.Threading;
=======
using System.Collections.Generic;
<<<<<<< HEAD
>>>>>>> refs/remotes/origin/Alexis'BranchRenouveau

namespace RestaurationModel.DinerRoom
{
	public class CustomerGroup {
		public int GroupNumber;
<<<<<<< HEAD
	//	public List<Model.Kitchen.Food> GroupOrder;
		public int IDTable;
		public int GroupID;
	//	public EatStrategy EatStrategy;
=======
		public List<Kitchen.Food> GroupOrder;
		public int IDTable;
		public int GroupID;
		public EatStategy eatStrategy;
>>>>>>> refs/remotes/origin/Alexis'BranchRenouveau

		public void AskBread() {
		}
		public void AskWater() {
			throw new System.Exception("Not implemented");
		}
		public void Eat() {
			throw new System.Exception("Not implemented");
		}
		public int GetGroupNumber() {
			return this.GroupNumber;
		}
		public void SetGroupNumber()
        {
            Random rnd = new Random();
            int groupNumber = rnd.Next(1, 9);
            Console.WriteLine(groupNumber);
            this.GroupNumber = groupNumber;
        }
		public int GetGroupID() {
			return this.GroupID;
		}
		public void SetGroupID(int groupID) {
			this.GroupID = groupID;
		}
<<<<<<< HEAD
//		public void<Model.Kitchen.Food> GetGroupOrder() {
//			throw new System.Exception("Not implemented");
//		}
//		public void SetGroupOrder(object<Model.Kitchen.Food> groupOrder) {
//			throw new System.Exception("Not implemented");
//		}

        public void ChooseOrder()
        {
            // TODO : modifier ?
            // Le client choisi son plat, il met au moins 5 min
            Console.WriteLine("CustomerGroup : Il nous faut au moins 5 min pour choisir nos plats !!"); // TODO : a enlever --> log
            Thread.Sleep(5000); //wait 5sec for choose order
            Console.WriteLine("CustomerGroup : Nous avons choisi nos plats !!"); // TODO : a enlever --> log
        }

		private EatStategy eatStategy;

		// private Person person;

=======
		public List<Kitchen.Food> GetGroupOrder() {
=======
using System.Threading;

namespace RestaurationModel.DinerRoom
{
    public class CustomerGroup : Person
    {
        public int GroupNumber;
        public List<Kitchen.Food> GroupOrder = new List<Kitchen.Food>();
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
        public void SetGroupNumber(int groupNumber)
        {
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
        public List<Kitchen.Food> GetGroupOrder()
        {
>>>>>>> refs/remotes/origin/Alexis'BranchRenouveau
            return this.GroupOrder;
        }
        public void SetGroupOrder(List<Kitchen.Food> groupOrder)
        {
            this.GroupOrder = groupOrder;
        }

<<<<<<< HEAD
		private EatStategy eatStategy;
		private Person person;
>>>>>>> refs/remotes/origin/Alexis'BranchRenouveau
	}
=======
        private EatStategy eatStategy;
        private Person person;
        private int v;
    }
>>>>>>> refs/remotes/origin/Alexis'BranchRenouveau

}
