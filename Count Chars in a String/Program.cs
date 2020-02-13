using System;
using System.Collections.Generic;
using System.Linq;

namespace Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] line = Console.ReadLine().ToArray();
            Dictionary<char, int> characters = new Dictionary<char, int>();

            for (int i = 0; i < line.Length; i++)
            {
                
                if (!characters.ContainsKey(line[i]) && line[i]!=' ')
                {
                    characters.Add(line[i],1);
                }
                else if(characters.ContainsKey(line[i]) && line[i] != ' ')
                {
                    characters[line[i]]++;
                }
            }

            foreach (var item in characters)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}

