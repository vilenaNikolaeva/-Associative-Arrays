using System;
using System.Collections.Generic;

namespace Word_Synonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            var words = new Dictionary<string, List<string>>();

            for (int i = 0; i < number; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();
                if (!words.ContainsKey(word))
                {
                    words[word]=new List<string>();
                }
                words[word].Add(synonym);
            }

            foreach (var item in words)
            {
                var word = item.Key;
                var synonym = item.Value;
                Console.WriteLine($"{word} - {string.Join(", ", synonym)}");
            }
        }
    }
}
