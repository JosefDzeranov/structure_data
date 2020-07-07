using System;
using System.Collections.Generic;

namespace SetOnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            new HashSet<>()
            var line = Console.ReadLine().Split();

            var set = new SetOnArray();
            foreach (var item in line)
            {
                set.Add(int.Parse(item));
            }

            int beforeLength = set.Items.Count;
            var beforePrinted = set.Print();

            
            line = Console.ReadLine().Split();

            var otherSet = new SetOnArray();
            foreach (var item in line)
            {
                otherSet.Add(int.Parse(item));
            }

            bool isSubset = set.IsSubset(otherSet);

            if (isSubset)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            
            int afterLength = set.Items.Count;
            if (beforeLength != afterLength)
                throw new Exception("Метод \"IsSubset\" изменяет кол-во элементов");

            var afterPrinted = set.Print();
            if (beforePrinted != afterPrinted)
                throw new Exception("Метод \"IsSubset\" изменяет элементы множества");
        }
    }
}