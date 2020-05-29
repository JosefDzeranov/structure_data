using System;
using System.Collections.Generic;

namespace DoubleCircularLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            // Считываем количество элементов
            int n = Convert.ToInt32(Console.ReadLine());

            // Считываем сами числа
            string[] values = Console.ReadLine().Split();

            // Заводим связный список
            LinkedList<int> list = new LinkedList<int>();

            for (int i = 0; i < n; i++)
            {
                // Получаем очередное число
                int number = Convert.ToInt32(values[i]);

                // Добавляем в список
                list.AddLast(number);
            }

            int result = 0;
            int count = list.Count - 1;
            foreach (var node in list)
            {
                result += (int) Math.Pow(2, count--) * node;
            }

            Console.WriteLine(result);
        }
    }
}