using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleHashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var dict = new Dictionary<int, List<string>>();
            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Split();
                var name = line[0];
                var month = int.Parse(line[2]);
                if (dict.ContainsKey(month))
                {
                    dict[month].Add(name);
                }
                else
                {
                    dict[month] = new List<string> {name};
                }
            }

            var m = int.Parse(Console.ReadLine());
            for (int i = 0; i < m; i++)
            {
                var month = int.Parse(Console.ReadLine());
                if (dict.ContainsKey(month))
                {
                    foreach (var item in dict[month])
                    {
                        Console.Write(item + " ");
                    }

                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("-");
                }
            }
        }
    }
}