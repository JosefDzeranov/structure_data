using System;
using SinglyLinkedList;

namespace SinglyLinkedListWithTail
{
    class Program
    {
        static void Main(string[] args)
        {
            SinglyLinkedListWithTail list = new SinglyLinkedListWithTail();
            list.PushBack(1);
            list.RemoveFirst(); // удаляем элемент

            list.PushBack(1);
            list.RemoveLast(); // отработает правильно по приведенному в лекции коду
            var tail = list.Tail; // возвращает элемент, чего быть не должно

            list.PushBack(1);
            Node one = list.Find(1);
            list.RemoveNode(one); // отработает правильно по приведенному в лекции коду
        }
    }
}