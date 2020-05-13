using System;

namespace SinglyLinkedListWithTail
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new SinglyLinkedListWithTail();
            list.PushBack(5);
            list.PushBack(6);
            list.PushBack(7);
            list.PushBack(8);
            Console.WriteLine(list.Print());
        }
    }
}