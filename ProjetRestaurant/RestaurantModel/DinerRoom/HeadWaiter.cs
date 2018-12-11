using RestaurationModel.Kitchen;
using System;
using System.Collections.Generic;
using static RestaurationModel.Table;

namespace RestaurationModel.DinerRoom
{
	public class HeadWaiter {
		public int SquareAssign;
		public int RankAssign;

		public void DressageTable(int iDTable, TableStatus status) {
			throw new System.Exception("Not implemented");
		}
		public void GiveMenu(int iDTable, int seatNumber) {
			throw new System.Exception("Not implemented");
		}
		public void GetMenu() {
			throw new System.Exception("Not implemented");
		}
		public List<Food> GetGroupOrder() {
			throw new System.Exception("Not implemented");
		}
		public void GiveOrder(List<Food> order) {
			throw new System.Exception("Not implemented");
		}
		public void ShowTableToCustomers() {
			throw new System.Exception("Not implemented");
		}
		
		private Person person;

	}

}
