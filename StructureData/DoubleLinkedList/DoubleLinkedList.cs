﻿using System;

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
            if (node == null)
            {
                return;
            }

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
            if (Head != null)
            {
                Head.Previous = null;
            }

            count--;
        }

        public void RemoveLast()
        {
            if (count == 0)
            {
                throw new Exception("Список пуст");
            }

            if (count == 1)
            {
                Head = null;
            }
            else
            {
                Node current = Head;
                while (current.Next.Next != null)
                {
                    current = current.Next;
                }

                current.Next = null;
            }

            count--;
        }

        public void RemoveNode(Node node)
        {
            if (Head == node)
            {
                RemoveFirst();
                return;
            }

            Node prev = node.Previous;

            prev.Next = node.Next;

            if (node.Next != null)
            {
                node.Next.Previous = prev;
            }

            count--;
        }

        // для реализации
        public Node FindLast(int key)
        {
            Node node = Head;
            Node result = null;
            while (node != null)
            {
                if (node.Value == key)
                {
                    result = node;
                }

                node = node.Next;
            }

            return result;
        }

        public void AddAfter(Node node, int item)
        {
            if (node.Next == null)
            {
                Node newNode = new Node(item);
                node.Next = newNode;
                newNode.Previous = node;
                count++;
            }
            else
            {
                AddBefore(node.Next, item);
            }
        }

        public bool Remove(int item)
        {
            var node = Find(item);
            if (node != null)
            {
                RemoveNode(node);
                return true;
            }

            return false;
        }

        public bool RemoveLast(int item)
        {
            var node = FindLast(item);
            if (node != null)
            {
                RemoveNode(node);
                return true;
            }

            return false;
        }

        public void Group()
        {
            if (Head == null)
                return;
            Node odd = Head, even = Head.Next, evenHead = even;
            while (even != null && even.Next != null)
            {
                odd.Next = even.Next;
                odd.Next.Previous = odd;
                odd = odd.Next;
                even.Next = odd.Next;

                if (even.Next != null)
                    even.Next.Previous = even;

                even = even.Next;
            }

            odd.Next = evenHead;
            if (evenHead != null)
                evenHead.Previous = odd;
        }

        public string PrintReverse()
        {
            var result = "";
            var current = FindTail();
            while (current != null)
            {
                result += current.Value + " ";
                current = current.Previous;
            }

            return result;
        }
    }
}