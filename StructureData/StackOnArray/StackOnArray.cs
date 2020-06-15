using System;

namespace StackOnArray
{
    public class StackOnArray
    {
        private int[] items;

        private int size = 0;

        public StackOnArray()
        {
            items = new int[0];
        }

        public string Print()
        {
            string result = "";
            for (int i = 0; i < size; i++)
            {
                result += items[i] + " ";
            }

            return result;
        }

        public bool Empty()
        {
            return size == 0;
        }


        public void Push(int item)
        {
            if (size == items.Length)
            {
                IncreaseArray();
            }

            items[size] = item;
            size++;
        }

        public int Pop()
        {
            if (size == 0)
            {
                throw new Exception("Стек пустой.");
            }

            int lastItem = items[size - 1];
            size--;
            return lastItem;
        }

        public int Peek()
        {
            if (size == 0)
            {
                throw new Exception("Стек пустой.");
            }

            return items[size - 1];
        }

        public void Clear()
        {
            size = 0;
        }

        private void IncreaseArray()
        {
            int newCount = size * 2;
            if (size == 0)
            {
                newCount = 4;
            }

            var newArray = new int[newCount];
            for (int i = 0; i < size; i++)
            {
                newArray[i] = items[i];
            }

            items = newArray;
        }
    }
}