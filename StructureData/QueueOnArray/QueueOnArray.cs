using System;
using System.Collections.Generic;

namespace QueueOnArray
{
    public class QueueOnArray
    {
        private List<int> items;

        public QueueOnArray()
        {
            items = new List<int>();
        }

        public string Print()
        {
            string result = "";
            foreach (var item in items)
            {
                result += item + " ";
            }

            return result;
        }

        public bool Empty()
        {
            return items.Count == 0;
        }

        public void Push(int item)
        {
            items.Add(item);
        }

        public int Pop()
        {
            if (items.Count == 0)
            {
                throw new Exception("Очередь пустая.");
            }

            int lastItem = items[0];
            items.RemoveAt(0);
            return lastItem;
        }

        public int Peek()
        {
            if (items.Count == 0)
            {
                throw new Exception("Очередь пустая.");
            }

            return items[0];
        }

        public void Clear()
        {
            items.Clear();
        }
    }
}