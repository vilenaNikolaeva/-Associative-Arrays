using System;
using System.Collections.Generic;

namespace A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new Dictionary<string, int>();
           
            string resource = Console.ReadLine();
            int quantiti = 0;
            while (resource!="stop")
            {
                if (resource=="stop")
                {
                    break;
                }
                quantiti = int.Parse(Console.ReadLine());
                if (!data.ContainsKey(resource))
                {
                    data.Add(resource, 0);
                    data[resource] += quantiti;
                }
                else
                {
                    data[resource] += quantiti;
                }
                resource = Console.ReadLine();
               
            }

            foreach (var item in data)
            {
                var resours = data.Keys;
                var qantiti = data.Values;
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
