using System;

namespace StackOnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            StackOnArray stack = new StackOnArray();
            stack.Push(3); // Добавить 3
            stack.Push(4); // Добавить 4
            stack.Push(6); // Добавить 6
            Console.WriteLine(stack.Print()); // выводит 3 4 6

            stack.Clear();
            Console.WriteLine(stack.GetCount()); // выводит 0
            Console.WriteLine(stack.Print()); // выводит пустую строку
        }
    }
}