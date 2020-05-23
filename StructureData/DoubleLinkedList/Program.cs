using System;

namespace DoubleLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            DoubleLinkedList doubleLinkedList = new DoubleLinkedList();

            doubleLinkedList.PushBack(6); // добавить в конец 6
            doubleLinkedList.PushBack(7); // добавить в конец 7
            Console.WriteLine(doubleLinkedList.Print()); // выводит "6 7"


            doubleLinkedList.PushFront(4); // добавить в начало 4
            doubleLinkedList.PushFront(3); // добавить в начало 3
            Console.WriteLine(doubleLinkedList.Print()); // выводит "3 4 6 7"


            Node node = doubleLinkedList.Find(7); // Получить узел со значением 7
            Console.WriteLine(node == null); // False

            node = doubleLinkedList.Find(8); // Получить узел со значением 8
            Console.WriteLine(node == null); // True


            var count = doubleLinkedList.GetCount(); // Получить количество элементов 
            Console.WriteLine(count); // выводит 4


            var findNode = doubleLinkedList.Find(6); // Найдем узел со значеним 6
            doubleLinkedList.AddBefore(findNode, 5); // Вставим новый узел со значением 5, перед переданным узлом
            Console.WriteLine(doubleLinkedList.Print()); // выводит "3 4 5 6 7"
        }
    }
}