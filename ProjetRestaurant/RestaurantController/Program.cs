using RestaurationModel.DinerRoom;
using System;

namespace RestaurantController
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            CustomerGroup customer = new CustomerGroup();
            customer.SetGroupNumber(); // TODO : action bdd
            customer.GroupID = 1; // TODO : a changer pour que ça se génère

            if (customer.GroupNumber <= 5) // TODO : useless, il faudra mettre le choix de la table à la place
            {
                Console.WriteLine("Les clients sont moins ou egale à 5"); // TODO : a enlever
                customer.IDTable = 1;
            }
            else
            {
                Console.WriteLine("Les clients sont plus de 5"); // TODO : a enlever
                customer.IDTable = 6;
            }

            HeadWaiter headwaiter = new HeadWaiter();
            headwaiter.ShowTableToCustomers(customer.IDTable, customer.GroupID);
            headwaiter.GetMenu(customer.GroupNumber, customer.IDTable);
            headwaiter.GiveMenu(customer.GroupNumber, customer.IDTable);
            customer.ChooseOrder();

            // TODO : le client passe commande
            // TODO : Le headwaiter transmet la commande
            headwaiter.GetBackMenu(customer.IDTable, customer.GroupID); // headWaiter ramène les cartes
            // TODO : Le serveur amène les plats quand ils sont tous prêts
            // TODO : Le client mange
            // TODO : ...
            // TODO : Le client s'en va
            // TODO : Le client va payer
            // TODO : Le client paye
            // TODO : Le serveur débarasse la table
            headwaiter.DressageTable(customer.IDTable); // headwaiter dresse la nouvelle table

            Console.ReadLine();

        }
    }
}
