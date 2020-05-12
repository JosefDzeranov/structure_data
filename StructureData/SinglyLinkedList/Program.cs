using System;

namespace SinglyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            #region проверка FindByIndex

            // var line = Console.ReadLine().Split();
            //
            // var list = new SinglyLinkedList();
            // foreach (var item in line)
            // {
            //     list.PushBack(int.Parse(item));
            // }
            // int beforeLength = line.Length;
            // var beforePrinted = list.Print();
            //
            // var index = int.Parse(Console.ReadLine());
            // var node = list.FindByIndex(index);
            // Console.WriteLine(node?.Value);
            //
            // int afterRemoveLength = list.GetCount();
            // if (beforeLength != afterRemoveLength)
            //     throw new Exception("Метод \"FindByIndex\" изменяет кол-во элементов");
            //
            // var afterPrinted = list.Print();
            // if (beforePrinted != afterPrinted)
            //     throw new Exception("Метод \"FindByIndex\" изменяет элементы массива");

            #endregion

            #region проверка FindLast

            // var line = Console.ReadLine().Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries);
            //
            // var list = new SinglyLinkedList();
            // foreach (var item in line)
            // {
            //     list.PushBack(int.Parse(item));
            // }
            //
            // int beforeLength = line.Length;
            // var beforePrinted = list.Print();
            //
            // var key = int.Parse(Console.ReadLine());
            // var node = list.FindLast(key);
            // Console.WriteLine(node?.Value);
            //
            // Console.WriteLine(node?.Next?.Value);
            //
            // int afterRemoveLength = list.GetCount();
            // if (beforeLength != afterRemoveLength)
            //     throw new Exception("Метод \"FindLast\" изменяет кол-во элементов");
            //
            // var afterPrinted = list.Print();
            // if (beforePrinted != afterPrinted)
            //     throw new Exception("Метод \"FindLast\" изменяет элементы массива");

            #endregion

            #region проверка PushBackRange

            // var line = Console.ReadLine().Split();
            // var line2 = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            // var array = new int[line2.Length];
            // for (int i = 0; i < line2.Length; i++)
            // {
            //     array[i] = int.Parse(line2[i]);
            // }
            // int expectedLength = line.Length + line2.Length;
            // var list = new SinglyLinkedList();
            // foreach (var item in line)
            // {
            //     list.PushBack(int.Parse(item));
            // }
            // list.PushBackRange(array);
            //
            // if (list.GetCount() != expectedLength)
            //     throw new Exception("Кол-во элементво в массиве должна быть равна сумме длин двух массивов.");
            //
            // Console.WriteLine(list.Print());

            #endregion

            #region проверка AddBefore

            // var line = Console.ReadLine().Split();
            // var list = new SinglyLinkedList();
            // for (int i = 0; i < line.Length; i++)
            // {
            //     list.PushBack(int.Parse(line[i]));
            // }
            // int expectedLength = line.Length + 1;
            //
            // int key = int.Parse(Console.ReadLine());
            // var node = list.Find(key);
            //
            // int item = int.Parse(Console.ReadLine());
            //
            // list.AddBefore(node, item);
            //
            // if (list.GetCount() != expectedLength)
            //     throw new Exception("Кол-во элементво в списке после добавления должна быть на 1 больше, чем до добавления.");
            //
            // Console.WriteLine(list.Print());

            #endregion

            SinglyLinkedList singlyLinkedList = new SinglyLinkedList();

            singlyLinkedList.PushBack(6);
            singlyLinkedList.PushBack(7);
            singlyLinkedList.PushFront(4);
            singlyLinkedList.PushFront(3);
            Console.WriteLine(singlyLinkedList.Print()); // выводит "3 4 6 7"


            singlyLinkedList.RemoveFirst();
            Console.WriteLine(singlyLinkedList.Print()); // выводит "4 6 7"


            singlyLinkedList.RemoveLast();
            Console.WriteLine(singlyLinkedList.Print()); // выводит "4 6"
            
            singlyLinkedList.PushBack(10);
            Console.WriteLine(singlyLinkedList.Print()); // выводит "4 6 10"

            Node node = singlyLinkedList.Find(6); // нашли узел со значением 6
            singlyLinkedList.RemoveNode(node); // удаляем данный узел
            Console.WriteLine(singlyLinkedList.Print()); // выводит "4 10"
            
            node = singlyLinkedList.Find(4); // нашли узел со значением 4
            singlyLinkedList.RemoveNode(node); // удаляем данный узел
            Console.WriteLine(singlyLinkedList.Print()); // выводит "10"
            
            node = singlyLinkedList.Find(10); // нашли узел со значением 4
            singlyLinkedList.RemoveNode(node); // удаляем данный узел
            Console.WriteLine(singlyLinkedList.Print()); // выводит пустую строку
        }
    }
}