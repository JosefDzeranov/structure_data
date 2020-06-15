using System;
using System.Collections.Generic;

namespace QueueOnLinkedList
{
    public class QueueOnLinkedList
    {
        private LinkedList<int> items;

        public QueueOnLinkedList()
        {
            items = new LinkedList<int>();
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
            items.AddLast(item);
        }

        public int Pop()
        {
            if (items.Count == 0)
            {
                throw new Exception("Стек пустой.");
            }

            int lastItem = items.First.Value;
            items.RemoveFirst();
            return lastItem;
        }

        public int Peek()
        {
            if (items.Count == 0)
            {
                throw new Exception("Стек пустой.");
            }

            return items.First.Value;
        }

        public void Clear()
        {
            items.Clear();
        }
    }
}