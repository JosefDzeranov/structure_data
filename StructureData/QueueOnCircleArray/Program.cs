using System;

namespace QueueOnCircleArray
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            QueueOnCircleArray queue = new QueueOnCircleArray();
            queue.Push(3); // Добавить 3
            queue.Push(4); // Добавить 4
            queue.Push(6); // Добавить 6
            Console.WriteLine(queue.Print()); // выводит 3 4 6
            
            int deletedItem = queue.Pop(); // удалить первый элемент
            Console.WriteLine(deletedItem); // выводит 3
            Console.WriteLine(queue.Print()); // выводит 4 6
            
            deletedItem = queue.Pop(); // удалить первый элемент
            Console.WriteLine(deletedItem); // выводит 4
            Console.WriteLine(queue.Print()); // выводит 6
            
            deletedItem = queue.Pop(); // удалить первый элемент
            Console.WriteLine(deletedItem); // выводит 6
            Console.WriteLine(queue.Print()); // выводит пустую строку
            
            queue.Pop(); // Ошибка
        }
    }
}