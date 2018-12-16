using ProjectLibrary.Business.RestaurantKitchen;
using ProjetLibrary.Business.RestaurantDinerRoom.DinerRoom;
using ProjetLibrary.Service;
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
                Console.WriteLine("Description du Scenario : " + item.Description+ " \nAction : " + item.Action.MethodRef+ " \n Ordre :" +item.OrderStage + "\n Role :"+ item.Action.Role.Entitled);
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
                    Console.WriteLine("Utiliser par le role :" +item.Action.Role.Entitled);
                    var test = item.Action.Role.Entitled;
                    switch (test) {
                        case "CustomerGroup":
                            Type type = typeof(CustomerGroup);
                            MethodInfo method = type.GetMethod(item.Action.MethodRef);
                            CustomerGroup c = new CustomerGroup();
                            string result = (string)method.Invoke(c, null);
                            Console.WriteLine(result);
                            break;
                        case "Assistant":
                            Type type1 = typeof(Assistant);
                            MethodInfo method1 = type1.GetMethod(item.Action.MethodRef);
                            Assistant a = new Assistant();
                            string result1 = (string)method1.Invoke(a, null);
                            Console.WriteLine(result1);
                            break;
                        case "Butler":
                            Type type2 = typeof(Buttler);
                            MethodInfo method2 = type2.GetMethod(item.Action.MethodRef);
                            Buttler b = new Buttler();
                            string result2 = (string)method2.Invoke(b, null);
                            Console.WriteLine(result2);
                        break;
                        case "HeadWaiter":
                            Type type3 = typeof(HeadWaiter);
                            MethodInfo method3 = type3.GetMethod(item.Action.MethodRef);
                            HeadWaiter h = new HeadWaiter();
                            string result3 = (string)method3.Invoke(h, null);
                            Console.WriteLine(result3);
                        break;
                        case "Waiter":
                            Type type4 = typeof(Waiter);
                            MethodInfo method4 = type4.GetMethod(item.Action.MethodRef);
                            Waiter w = new Waiter();
                            string result4 = (string)method4.Invoke(w, null);
                            Console.WriteLine(result4);
                        break;
                        case "Chef":
                            Type type5 = typeof(Chef);
                            MethodInfo method5 = type5.GetMethod(item.Action.MethodRef);
                            Chef c1 = new Chef();
                            string result5 = (string)method5.Invoke(c1, null);
                            Console.WriteLine(result5);
                        break;
                        case "HeadChef":
                            Type type6 = typeof(Chef);
                            MethodInfo method6 = type6.GetMethod(item.Action.MethodRef);
                            Chef h1 = new Chef();
                            string result6 = (string)method6.Invoke(h1, null);
                            Console.WriteLine(result6);
                        break;
                        case "AssistantCook":
                            Type type7 = typeof(Chef);
                            MethodInfo method7 = type7.GetMethod(item.Action.MethodRef);
                            Chef a1 = new Chef();
                            string result7 = (string)method7.Invoke(a1, null);
                            Console.WriteLine(result7);
                        break;

                }
            }
            Console.Read();
        }
              
        private Person person;
        private Table table;
        private ProjectLibrary.Business.RestaurantKitchen.Food food;


    }
}
