using System;
using SocketHelper;

namespace TestClient
{
    class Program
    {
        public static string currentIp = "localhost";
        public static int currentPort = 2000;

        static void Main(string[] args)
        {
            Server serverResponse = new Server(currentIp, currentPort, new ReceivedMessage(messageRecu));
            serverResponse.Start();
            Client client = new Client("localhost", 9000);
            Meal meal = new Meal("soupe miso", "sushi maki", "perle de coco");
            Meal meal2 = new Meal(null, "summer roll", "glace vanille");
            Meal[] meals = new Meal[2];
            meals[0] = meal;
            meals[1] = meal2;
            Message message = GenerateCommande(1, 1, meals);
            client.SentMessage(message);
            Console.Read();
            serverResponse.Stop();
        }

        public static Message GenerateCommande(int table, int rank, Meal[] meals)
        {
            Message message = new Message();
            message.action = "commande";
            message.senderIp = currentIp;
            message.senderPort = currentPort;
            message.table = table;
            message.rank = rank;
            message.meals = meals;
            return message;
        }

        public static void messageRecu(Message messageServer)
        {
            Console.WriteLine(messageServer.action);
        }
    }
}
