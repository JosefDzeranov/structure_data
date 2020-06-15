using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Queue<int> numbers = new Queue<int>();
        numbers.Enqueue(1);
        numbers.Enqueue(2);
        numbers.Dequeue();
        numbers.Enqueue(15);
        numbers.Peek();
        numbers.Enqueue(20);
        numbers.Dequeue();
        foreach (int item in numbers)
        {
            Console.Write(item + " ");
        }
    }
}