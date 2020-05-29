using System.Collections.Generic;

namespace SinglyCircularLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            #region FindLast

            // var line = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            //
            // var list = new SinglyCircularLinkedList();
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

            #region AddBefore

            // var line = Console.ReadLine().Split();
            // var list = new SinglyCircularLinkedList();
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
            // list.AddBefore(node, item);
            //
            // if (list.GetCount() != expectedLength)
            //     throw new Exception(
            //         "Кол-во элементво в списке после добавления должна быть на 1 больше, чем до добавления.");
            //
            // Console.WriteLine(list.Print());

            #endregion

            #region Remove

            // var line = Console.ReadLine().Split();
            // int beforeRemoveLength = line.Length;
            // var list = new SinglyCircularLinkedList();
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

            #region RemoveLast
            // var line = Console.ReadLine().Split();
            // int beforeRemoveLength = line.Length;
            // var list = new SinglyCircularLinkedList();
            // foreach (var item in line)
            // {
            //     list.PushBack(int.Parse(item));
            // }
            // var itemToRemove = int.Parse(Console.ReadLine());
            // var isRemove = list.RemoveLast(itemToRemove);
            // Console.WriteLine(list.Print());
            //
            // int afterRemoveLength = list.GetCount();
            //
            // if (beforeRemoveLength == afterRemoveLength && isRemove)
            //     throw new Exception("Метод \"RemoveLast\" возвращает неправильное значение");
            //
            // if (beforeRemoveLength != afterRemoveLength && !isRemove)
            //     throw new Exception("Метод \"RemoveLast\" возвращает неправильное значение");
            #endregion
        }
    }
}