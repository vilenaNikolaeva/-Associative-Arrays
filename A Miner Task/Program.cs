using System;
using System.Collections.Generic;

namespace A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
             var resourses = new Dictionary<string, int>();
            var resours = string.Empty;

            while (resours != "stop")
            {
                resours = Console.ReadLine();
                if (resours=="stop")
                {
                    break;
                }
                var quantiti =int.Parse(Console.ReadLine());

                if (!resourses.ContainsKey(resours))
                {
                    resourses.Add(resours,0);
                }
                resourses[resours] += quantiti;
            }
            foreach (var item in resourses)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
