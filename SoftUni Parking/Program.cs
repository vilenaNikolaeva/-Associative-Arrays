using System;
using System.Collections.Generic;

namespace SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> users = new Dictionary<string, string>();

            int usersCount = int.Parse(Console.ReadLine());

            for (int i = 0; i <usersCount; i++)
            {
                string[] regester = Console.ReadLine().Split(" ");
                string commnand = regester[0];
                string name = regester[1];
                

                if (commnand=="register")
                {
                    string carNumber = regester[2];
                    if (!users.ContainsKey(name))
                    {
                        users.Add(name,carNumber);
                        Console.WriteLine($"{name} registered {carNumber} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {carNumber}");
                    }
                   
                }
                else if (commnand=="unregister")
                {
                    if (!users.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                    }
                    else
                    {
                        users.Remove(name);
                        Console.WriteLine($"{name} unregistered successfully");
                    }
                }
            }
            foreach (var kvp in users)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }
        }
    }
}
