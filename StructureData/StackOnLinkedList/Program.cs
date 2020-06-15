using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Stack<int> numbers = new Stack<int>();
        numbers.Push(1);
        numbers.Push(2);
        numbers.Push(3);
        numbers.Push(4);
        foreach (int item in numbers)
        {
            Console.Write(item + " ");
        }
    }
}