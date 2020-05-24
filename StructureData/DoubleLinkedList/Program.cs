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

            #region AddAfter

            // var line = Console.ReadLine().Split();
            // var list = new DoubleLinkedList();
            // for (int i = 0; i < line.Length; i++)
            // {
            //     list.PushBack(int.Parse(line[i]));
            // }
            //
            // int expectedLength = line.Length + 1;
            //
            // int key = int.Parse(Console.ReadLine());
            // var node = list.Find(key);
            //
            // int item = int.Parse(Console.ReadLine());
            // list.AddAfter(node, item);
            //
            // if (list.GetCount() != expectedLength && node != null)
            //     throw new Exception(
            //         "Кол-во элементво в списке после добавления должна быть на 1 больше, чем до добавления.");
            //
            // Console.WriteLine(list.Print());

            #endregion

            #region Remove

            // var line = Console.ReadLine().Split();
            // int beforeRemoveLength = line.Length;
            // var list = new DoubleLinkedList();
            // foreach (var item in line)
            // {
            //     list.PushBack(int.Parse(item));
            // }
            //
            // var itemToRemove = int.Parse(Console.ReadLine());
            // var isRemove = list.Remove(itemToRemove);
            // Console.WriteLine(list.Print());
            //
            // int afterRemoveLength = list.GetCount();
            //
            // if (beforeRemoveLength == afterRemoveLength && isRemove)
            //     throw new Exception("Метод \"Remove\" возвращает неправильное значение");
            //
            // if (beforeRemoveLength != afterRemoveLength && !isRemove)
            //     throw new Exception("Метод \"Remove\" возвращает неправильное значение");

            #endregion
        }
    }
}