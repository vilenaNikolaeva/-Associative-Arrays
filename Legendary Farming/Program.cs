using System;
using System.Collections.Generic;
using System.Linq;

namespace Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> keyMaterial = new Dictionary<string, int>();
            keyMaterial["motes"] = 0;
            keyMaterial["fragments"] = 0;
            keyMaterial["shards"] = 0;

            Dictionary<string, int> junkMaterial = new Dictionary<string, int>();
            var hasToBreak = false;

            while (!hasToBreak)
            {
                string[] input = Console.ReadLine()
                    .ToLower()
                    .Split(" ");
                hasToBreak = false;

                for (int i = 0; i < input.Length; i+=2)
                {
                    var quantiti = int.Parse(input[i]);
                    string type = input[i + 1];

                    if (type=="motes")
                    {
                        keyMaterial[type] += quantiti;
                        if (keyMaterial[type]>=250)
                        {
                            Console.WriteLine($"Dragonwrath obtained!");
                            keyMaterial[type] -= 250;
                            hasToBreak = true;
                            break;
                        }
                    }
                    else if (type=="shards")
                    {
                        keyMaterial[type] += quantiti;
                        if (keyMaterial[type] >= 250)
                        {
                            Console.WriteLine($"Shadowmourne obtained!");
                            keyMaterial[type] -= 250;
                            hasToBreak = true;
                            break;
                        }
                    }
                    else if (type=="fragments")
                    {
                        keyMaterial[type] += quantiti;
                        if (keyMaterial[type] >= 250)
                        {
                            Console.WriteLine($"Valanyr obtained!");
                            keyMaterial[type] -= 250;
                            hasToBreak = true;
                            break;
                        }
                    }
                    else
                    {
                        if (!junkMaterial.ContainsKey(type))
                        {
                            junkMaterial[type] = 0;
                        }
                        junkMaterial[type] += quantiti;
                    }
                }
            }

            keyMaterial = keyMaterial
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            junkMaterial = junkMaterial
                .OrderBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var kvp in keyMaterial)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
            foreach (var kvp in junkMaterial)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }
}
