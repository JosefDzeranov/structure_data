using System;

namespace DoubleLinkedList
{
    public class DoubleLinkedList
    {
        public Node Head;
        private int count = 0;

        public int GetCount()
        {
            return count;
        }

        public string Print()
        {
            var result = "";
            var current = Head;
            while (current != null)
            {
                result += current.Value + " ";
                current = current.Next;
            }

            return result;
        }

        public Node Find(int key)
        {
            if (count == 0)
            {
                return null;
            }

            Node current = Head;
            while (current.Value != key)
            {
                current = current.Next;
                if (current == null)
                {
                    return null;
                }
            }

            return current;
        }

        private Node FindTail()
        {
            if (count == 0)
            {
                return null;
            }

            Node current = Head;
            while (current.Next != null)
            {
                current = current.Next;
            }

            return current;
        }

        public void PushBack(int item)
        {
            Node newNode = new Node(item);
            if (count == 0)
            {
                Head = newNode;
            }
            else
            {
                Node tail = FindTail();
                tail.Next = newNode;
                newNode.Previous = tail;
            }

            count++;
        }

        public void PushFront(int item)
        {
            Node newNode = new Node(item);

            if (count != 0)
            {
                newNode.Next = Head;
                Head.Previous = newNode;
            }

            Head = newNode;
            count++;
        }

        public void AddBefore(Node node, int item)
        {
            if (node == Head)
            {
                PushFront(item);
                return;
            }

            Node newNode = new Node(item);

            newNode.Next = node;
            newNode.Previous = node.Previous;

            node.Previous.Next = newNode;
            node.Previous = newNode;

            count++;
        }


        public void RemoveFirst()
        {
            if (count == 0)
            {
                throw new Exception("Список пуст");
            }

            Head = Head.Next;
            Head.Previous = null;
            count--;
        }
    }
}