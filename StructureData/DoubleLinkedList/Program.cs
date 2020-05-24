using System;

namespace DoubleLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Теория

            // DoubleLinkedList doubleLinkedList = new DoubleLinkedList();
            //
            // doubleLinkedList.PushBack(6); // добавить в конец 6
            // doubleLinkedList.PushBack(7); // добавить в конец 7
            // doubleLinkedList.PushFront(4); // добавить в начало 4
            // doubleLinkedList.PushFront(3); // добавить в начало 3
            // Console.WriteLine(doubleLinkedList.Print()); // выводит "3 4 6 7"
            //
            // doubleLinkedList.RemoveFirst();
            // Console.WriteLine(doubleLinkedList.Print()); // выводит "4 6 7"
            //
            // doubleLinkedList.RemoveLast();
            // Console.WriteLine(doubleLinkedList.Print()); // выводит "4 6"
            //
            // var count = doubleLinkedList.GetCount(); // Получить количество элементов 
            // Console.WriteLine(count); // выводит 2
            //
            //
            // doubleLinkedList.PushBack(10);
            // Console.WriteLine(doubleLinkedList.Print()); // выводит "4 6 10"
            //
            // Node node = doubleLinkedList.Find(6); // нашли узел со значением 6
            // doubleLinkedList.RemoveNode(node); // удаляем данный узел
            // Console.WriteLine(doubleLinkedList.Print()); // выводит "4 10"
            //
            // node = doubleLinkedList.Find(4); // нашли узел со значением 4
            // doubleLinkedList.RemoveNode(node); // удаляем данный узел
            // Console.WriteLine(doubleLinkedList.Print()); // выводит "10"
            //
            // node = doubleLinkedList.Find(10); // нашли узел со значением 4
            // doubleLinkedList.RemoveNode(node); // удаляем данный узел
            // Console.WriteLine(doubleLinkedList.Print()); // выводит пустую строку

            #endregion

            #region FindLast

            // var line = Console.ReadLine().Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries);
            //
            // var list = new DoubleLinkedList();
            // foreach (var item in line)
            // {
            //     list.PushBack(int.Parse(item));
            // }
            // int beforeLength = line.Length;
            // var beforePrinted = list.Print();
            //
            // var key = int.Parse(Console.ReadLine());
            // var node = list.FindLast(key);
            // Console.WriteLine(node?.Value);
            // Console.WriteLine(node?.Next?.Value);
            // Console.WriteLine(node?.Previous?.Value);
            //
            // int afterRemoveLength = list.GetCount();
            // if (beforeLength != afterRemoveLength)
            //     throw new Exception("Метод \"FindLast\" изменяет кол-во элементов");
            //
            // var afterPrinted = list.Print();
            // if (beforePrinted != afterPrinted)
            //     throw new Exception("Метод \"FindLast\" изменяет элементы массива");

            #endregion
        }
    }
}