using System;

namespace QueueOnCircleArray
{
    public class QueueOnCircleArray
    {
        private int[] items;
        private int size;
        private int capacity;
        private int head;
        private int tail;

        public QueueOnCircleArray()
        {
            size = 0;
            capacity = 0;
            items = new int[capacity];
            head = 0;
            tail = 0;
        }

        public string Print()
        {
            string result = "";
            if (head < tail)
            {
                for (int i = head; i < tail; i++)
                {
                    result += items[i] + " ";
                }
            }
            else
            {
                if (size == 0)
                {
                    return result;
                }

                for (int i = head; i < items.Length; i++)
                {
                    result += items[i] + " ";
                }

                for (int i = 0; i < tail; i++)
                {
                    result += items[i] + " ";
                }
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
                capacity = (capacity == 0) ? 4 : capacity * 2;

                int[] newItems = new int[capacity];
                if (size > 0)
                {
                    if (head < tail)
                    {
                        Array.Copy(items, head, newItems, 0, size);
                    }
                    else
                    {
                        Array.Copy(items, head, newItems, 0, items.Length - head);
                        Array.Copy(items, 0, newItems, items.Length - head, tail);
                    }
                }

                items = newItems;
                head = 0;
                tail = (size == capacity) ? 0 : size;
            }

            items[tail] = item;
            tail = (tail + 1) % items.Length;
            size++;
        }

        public int Pop()
        {
            if (size == 0)
                throw new Exception("Очередь пустая.");

            int removed = items[head];
            head = (head + 1) % items.Length;
            size--;
            return removed;
        }

        public int Peek()
        {
            if (size == 0)
                throw new Exception("Очередь пустая.");

            return items[head];
        }
        
        public void Clear()
        {
            head = 0;
            tail = 0;
            size = 0;
        }
    }
}