using System;
using System.Collections.Generic;

namespace Week10_In_Class_Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> inventory = new Dictionary<string, List<string>>();
            inventory.Add("gold", new List<string> { "500"});
            inventory.Add("pouch", new List<string> { "flint", "twine", "gemstone" });
            inventory.Add("backpack", new List<string> { "xylophone", "dagger", "bedroll", "bread roll" });
            inventory.Add("pocket", new List<string> { "seashell", "strange berry", "lint" });
            inventory["backpack"].Sort();
            inventory["backpack"].Remove("dagger");
            foreach (var item in inventory["gold"])
            {
                Convert.ToInt32(item);
                int goldInt = Convert.ToInt32(item);
                goldInt += 50;
                List<string> goldList = new List<string>();
                goldList.Add(Convert.ToString(goldInt));
                inventory["gold"] = goldList ;
            }
            foreach (var item in inventory["gold"])
            {
                Console.WriteLine(item);
            }      
            
           
            foreach (var item in inventory["backpack"])
            {
                Console.WriteLine(item);
            }
            double totalCost = 0;
            double producePrice = 0;
            double produceStock = 0;
            decimal totalMoney = 0.0m;

            Dictionary<string, Dictionary<string, double>> produce = new Dictionary<string, Dictionary<string, double>>
            {
                {
                    "bananas",
                    new Dictionary<string, double>
                    {
                        {"price", 4},
                        {"stock", 2}
                    }
                },
                {
                    "apple",
                    new Dictionary<string, double>
                    {
                        {"price", 2},
                        {"stock", 0 }
                    }
                },
                {
                    "orange",
                    new Dictionary<string, double>
                    {
                        {"price", 1.5 },
                        {"stock", 5 }
                    }
                },
                {
                    "pear",
                    new Dictionary<string, double> 
                    { 
                        {"price", 3 },
                        {"stock", 8}
                    }
                }
            };   
            foreach (var pair in produce)
            {
                foreach(var innerPair in pair.Value)
                {
                    Console.WriteLine("{0}->> {1}, {2}", pair.Key, innerPair.Key, innerPair.Value);
                    if (innerPair.Key == "price")
                    {
                        producePrice = innerPair.Value;
                    }
                    else if (innerPair.Key == "stock")
                    {
                        produceStock = innerPair.Value;
                    }
                   
                    totalCost = totalCost + (producePrice * produceStock);
                }
                
            }
            totalMoney = Convert.ToDecimal(totalCost);
            string outputTotalMoney = string.Format("Total for all produce: {0:C}", totalMoney);
            Console.WriteLine(outputTotalMoney);
        }
    }
}
