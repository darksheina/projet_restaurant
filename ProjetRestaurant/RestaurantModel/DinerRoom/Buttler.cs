using System;
using System.Collections.Generic;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace RestaurationModel.DinerRoom
{
	public class Buttler {
		
        public List<Table.TableStatus> GetTableStatus(List<Table.TableStatus> tableList)
        {
            List<Table.TableStatus> statusAllTable = null;
            for (int i = 0; i < tableList.Count; i++)
            {
                statusAllTable[i] = tableList[i];
            }
            return statusAllTable;
        }

		public int GetCustomerGroupNumber(CustomerGroup customerGroup)
        {
            return customerGroup.GroupNumber;
        }

		public void TableAttribution(CustomerGroup group, Table table)
        {
            // Methode à ameliorer pour un meilleur choix des tables
            if (group.GroupNumber <= table.SeatNumber)
            {
                group.SetGroupID(table.IDTable);
                table.status = Table.TableStatus.taken;
            }
            else if (group.GroupNumber >= table.SeatNumber)
            {
                Console.WriteLine("Autre table requise");
            }
		}

		public void CallHeadWaiter() {
			throw new System.Exception("Not implemented");
		}
		private Person person;
	}

}
