using System;
using System.Collections.Generic;
using System.Linq;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,double> products = new Dictionary<string,double>();
            bool hasToBreak = false;
            
            while (!hasToBreak)
            {
                string[] input = Console.ReadLine().Split(" ");
                string product = input[0];
                if (product=="buy")
                {
                    hasToBreak = true;
                    break;
                }
                double price =double.Parse(input[1]);
                double quantiti =double.Parse(input[2]);
               

                if (!products.ContainsKey(product))
                {
                    products.Add(product,price*quantiti);
                }
                else
                {
                    products[product] += price * quantiti;
                }
                
            }

            foreach (var kvp in products)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value:f2}");
            }
        }
    }
}
