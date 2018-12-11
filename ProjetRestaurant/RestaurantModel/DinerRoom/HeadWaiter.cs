using System;
using System.Threading;

namespace RestaurationModel.DinerRoom
{
	public class HeadWaiter {
		public int SquareAssign;
		public int RankAssign;

		public void DressageTable(int iDTable) {
            Console.WriteLine("HeadWaiter : Je dresse de nouveau la table " + iDTable); // TODO : a enlever --> log
            Thread.Sleep(4000); //wait 4sec for dressage table
            Console.WriteLine("HeadWaiter : La table " + iDTable + " est dressée"); // TODO : a enlever --> log
        }
        public void GiveMenu(int nbCustomers, int IDTable)
        {
            Console.WriteLine("HeadWaiter : Je donne les cartes pour les " + nbCustomers + " personnes de la table " + IDTable); // TODO : a enlever --> log
            Thread.Sleep(2000); //wait 2sec for give menus
        }
        public void GetMenu(int nbCustomers, int IDTable)
        {
            Console.WriteLine("HeadWaiter : Je vais chercher les cartes pour les " + nbCustomers + " personnes de la table " + IDTable); // TODO : a enlever --> log
            Thread.Sleep(2000); //wait 2sec for get menus
        }
		//public List<Model.Kitchen.Food> GetGroupOrder() {
		//	throw new System.Exception("Not implemented");
		//}
		//public void GiveOrder(list<String> order) {
		//	throw new System.Exception("Not implemented");
		//}
        public void ShowTableToCustomers(int IDTable, int GroupID)
        {
            Console.WriteLine("HeadWaiter : On place le client " + GroupID + " a la table " + IDTable); // TODO : a enlever --> log
            // TODO : Wait ? c'est le Maitre d'hotel qui bloque la table ?
            Thread.Sleep(2000); //wait 2sec for bring customers to their table
        }
		//public void Update(Observable observable) {
		//	throw new System.Exception("Not implemented");
		//}

		private Person person;

	}

}
