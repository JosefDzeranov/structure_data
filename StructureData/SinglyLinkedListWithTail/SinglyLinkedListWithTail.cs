using System;
using SinglyLinkedList;

namespace SinglyLinkedListWithTail
{
    public class SinglyLinkedListWithTail
    {
        public Node Head;
        public Node Tail;
        private int count = 0;

        public int GetCount()
        {
            return count;
        }

        public string Print()
        {
            string result = "";
            Node current = Head;
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

        public void PushBack(int item)
        {
            Node newNode = new Node(item);
            if (count == 0)
            {
                Head = newNode;
            }
            else
            {
                Tail.Next = newNode;
            }

            count++;
            Tail = newNode;
        }

        public void PushFront(int item)
        {
            Node newNode = new Node(item);

            if (count != 0)
            {
                newNode.Next = Head;
            }

            Head = newNode;
            count++;
        }

        public void AddAfter(Node node, int item)
        {
            Node newNode = new Node(item);

            newNode.Next = node.Next;
            node.Next = newNode;
            if (node == Tail)
            {
                Tail = newNode;
            }

            count++;
        }

        public void RemoveFirst()
        {
            if (count == 0)
            {
                throw new Exception("Список пуст");
            }

            if (count == 1)
            {
                Head = null;
                Tail = null;
            }
            else
            {
                Head = Head.Next;
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
                Tail = null;
            }
            else
            {
                Node current = Head;
                while (current.Next.Next != null)
                {
                    current = current.Next;
                }

                current.Next = null;
                Tail = current;
            }

            count--;
        }

        public void RemoveNode(Node node)
        {
            if (node == Head)
            {
                RemoveFirst();
            }
            else
            {
                Node current = Head;
                while (current.Next != null)
                {
                    if (current.Next == node)
                    {
                        break;
                    }

                    current = current.Next;
                }

                current.Next = node.Next;

                if (node == Tail)
                {
                    Tail = current;
                }

                count--;
            }
        }

        // добавленные методы
        public Node FindByIndex(int index)
        {
            if (index < 0 || index >= count)
                return null;
            int cur = 0;

            Node node = Head;
            while (cur != index)
            {
                node = node.Next;
                cur++;
            }

            return node;
        }

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

        public void PushBackRange(int[] array)
        {
            foreach (var item in array)
            {
                PushBack(item);
            }
        }


        public void AddBefore(Node node, int item)
        {
            count++;
            Node newNode = new Node(item);
            newNode.Next = node;
            if (node == Head)
            {
                Head = newNode;
                return;
            }

            Node current = Head;
            while (current.Next.Next != null)
            {
                if (current.Next == node)
                {
                    break;
                }

                current = current.Next;
            }

            current.Next = newNode;
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

        public int RemoveAll(int item)
        {
            int removedItemsCount = 0;

            Node node = Find(item);
            while (node != null)
            {
                RemoveNode(node);
                node = Find(item);
                removedItemsCount++;
            }

            return removedItemsCount;
        }
    }
}