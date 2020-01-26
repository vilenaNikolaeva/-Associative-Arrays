using System;
using System.Collections.Generic;
using System.Linq;

namespace Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToArray();

            var letters = new Dictionary<char, int>();

            foreach (var symbol in input)
            {
                if (!letters.ContainsKey(symbol))
                {
                    letters.Add(symbol, 1);
                }
                else
                {
                    letters[symbol]++;
                }
            }
            var result = new List<char>();

            foreach (var pair in letters)
            {
                var letter = pair.Key;
                var letterPair = pair.Value;
                Console.WriteLine($"{letter} -> {letterPair}");
            }

        }
        //да се премахне празното място между чаровете
    }
}

