using SocketHelper;
using System;
using System.Threading;

namespace TestServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Server server = new Server("localhost", 9000, new ReceivedMessage(messageRecu));
            server.Start();
            Console.Read();
            server.Stop();
        }

        public static void messageRecu(Message messageServer)
        {
            if(messageServer.action.Equals("commande") && messageServer.meals != null)
            {
                Console.WriteLine("Préparation d'une commande !");
                ThreadCuisine threadHandle = new ThreadCuisine(messageServer);
                Thread t = new Thread(new ThreadStart(threadHandle.ThreadLoop));
                t.Start();
            }
            else
            {
                Console.WriteLine("ce n'est pas une commande !");
            }
        }
    }

    public class ThreadCuisine
    {
        Message order;

        public ThreadCuisine(Message order)
        {
            this.order = order;
        }

        public void ThreadLoop()
        {
            Console.WriteLine("THREAD - Préparation de la commande");
            Client responses = new Client(order.senderIp, order.senderPort);
            int time = 0;
            if (order.meals.Length > 0)
            {
                time = 0;
                foreach (Meal meal in order.meals)
                {
                    if (meal.starter != null)
                    {
                        time += 2000;
                        Console.WriteLine("Préparation de l'entree :" + meal.starter + " (+ 2 secondes)");
                    }
                }
                if (time != 0)
                {
                    Thread.Sleep(time);
                    order.action = "starter ready";
                    responses.SentMessage(order);
                }
                time = 0;
                foreach (Meal meal in order.meals)
                {
                    if (meal.dish != null)
                    {
                        time += 5000;
                        Console.WriteLine("Préparation du plat :" + meal.dish + " (+ 5 secondes)");
                    }
                }
                if (time != 0)
                {
                    Thread.Sleep(time);
                    order.action = "dish ready";
                    responses.SentMessage(order);
                }
                time = 0;
                foreach (Meal meal in order.meals)
                {
                    if (meal.dessert != null)
                    {
                        time += 2000;
                        Console.WriteLine("Préparation du dessert :" + meal.dessert + " (+ 2 secondes)");
                    }
                }
                if (time != 0)
                {
                    Thread.Sleep(time);
                    order.action = "dessert ready";
                    responses.SentMessage(order);
                }
            }
            Console.WriteLine("Préparation de la commande est fini !");
        }
    }
}
