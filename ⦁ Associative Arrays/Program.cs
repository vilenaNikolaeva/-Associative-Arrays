using System;
using System.Collections.Generic;
using System.Linq;

namespace __Associative_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //⦁	Count Real Numbers

            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

            SortedDictionary<double, int> result = new SortedDictionary<double, int>();

            foreach (var number in numbers)
            {
                if (result.ContainsKey(number))
                {
                    result[number]++;
                }
                else
                {
                    result.Add(number, 1);
                }
            }
            foreach (var number in result)
            {
                Console.WriteLine($"{number.Key}->{number.Value}");
            }
        }
    }
}
