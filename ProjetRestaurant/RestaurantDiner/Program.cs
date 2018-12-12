using ProjectLibrary.Business;
using ProjectLibrary.Service;
using RestaurantDinerRoom.DALandBLL.Service;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace RestaurantDiner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quel action appeler ? :");
            string text = Console.ReadLine();
            /*int num = Convert.ToInt32(text);*/
            ActionService actionservice;
            actionservice = new ActionService();
            var test = actionservice.Get(text);
            Type type = typeof(Test);
            //Console.WriteLine("test :"+test.MethodRef);
            //Console.WriteLine("Entrez le nom de la méthode que vous voulez executer : ");
            MethodInfo method = type.GetMethod(test.MethodRef);
            Test c = new Test();
            string result = (string)method.Invoke(c, null);
            Console.WriteLine(result);
            Console.ReadLine();

        }
    }
}
