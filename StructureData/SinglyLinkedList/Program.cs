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

            var line = Console.ReadLine().Split();
            var line2 = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var array = new int[line2.Length];
            for (int i = 0; i < line2.Length; i++)
            {
                array[i] = int.Parse(line2[i]);
            }
            int expectedLength = line.Length + line2.Length;
            var list = new SinglyLinkedList();
            foreach (var item in line)
            {
                list.PushBack(int.Parse(item));
            }
            list.PushBackRange(array);

            if (list.GetCount() != expectedLength)
                throw new Exception("Кол-во элементво в массиве должна быть равна сумме длин двух массивов.");

            Console.WriteLine(list.Print());

            #endregion
        }
    }
}