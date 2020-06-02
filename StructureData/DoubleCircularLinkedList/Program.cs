using System;
using System.Collections.Generic;

namespace DoubleCircularLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            DoubleCircularLinkedList firstList = new DoubleCircularLinkedList();
            DoubleCircularLinkedList secondList = new DoubleCircularLinkedList();
            
            firstList.PushBack(10);
            firstList.PushBack(20);
            firstList.PushBack(30);
            secondList.PushBack(123);
            
            Console.WriteLine(firstList.Print(true)); // вывод 10 20 30
            Console.WriteLine(secondList.Print(true)); // вывод 123

            var found = secondList.Find(123);
            firstList.RemoveNode(found);
            
            Console.WriteLine(firstList.Print(true)); // вывод <string.Empty>
            Console.WriteLine(secondList.Print(true)); // вывод 123
        }
    }
}