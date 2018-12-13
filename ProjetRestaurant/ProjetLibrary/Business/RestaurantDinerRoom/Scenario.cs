using ProjectLibrary.Business;
using ProjectLibrary.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace ProjetLibrary.Business.RestaurantDinerRoom
{
    public class Scenario
    {
        public int HeadChefNumber;
        public int ChefNumber;
        public int AssistantCookNumber;
        public int ButlerNumber;
        public int HeadWaiterNumber;
        public int WaiterNumber;
        public int AssistantNumber;
        public int NiceCustomerGroupNumber;
        public int HungryCustomerGroupNumber;
        public int NormalCustomerGroupNumber;
        public int TableNumber;
        public int SpeedTime;

        public void SelectScenario()
        {
                     
        }

        public void ExecuteMethod()
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

        public int GetTypeScenario()
        {
            TypeScenarioService typescenario;
            typescenario = new TypeScenarioService();
            Console.WriteLine("Quel scenario executer ? :");
            string text = Console.ReadLine();
            var id = typescenario.Get(text);
            Console.WriteLine("id = {0}", id.ID);
            return id.ID;

        }

        public List<ScenarioBusiness> GetAllScenarioLines()
        {
            ScenarioService scenarioservice;
            scenarioservice = new ScenarioService();
            List<ScenarioBusiness> lines = scenarioservice.GetScenarioLines(GetTypeScenario());
            Console.WriteLine("\n");
            foreach (var item in lines.OrderBy(x => x.OrderStage))
            {
                Console.WriteLine("Description du Scenario : " + item.Description+ " \nAction : " + item.Action.MethodRef+ " \n Ordre :" +item.OrderStage);
            }
            
            return lines;
        }

        public void ExecuteScenario()
        {
            List<ScenarioBusiness> linesB;
            linesB = GetAllScenarioLines();
            foreach (var item in linesB)
            {
                Console.WriteLine("Methode à laquelle on fait réference : "+item.Action.MethodRef);
                Type type = typeof(Test);
                MethodInfo method = type.GetMethod(item.Action.MethodRef);
                Test c = new Test();
                string result = (string)method.Invoke(c, null);
                Console.WriteLine(result);
            }
            Console.Read();
        }

        
        private Person person;
        private Table table;
        private ProjectLibrary.Business.RestaurantKitchen.Food food;


    }
}
