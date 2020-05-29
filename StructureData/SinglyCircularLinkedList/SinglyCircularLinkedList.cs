
using System;
using SinglyLinkedList;

namespace SinglyCircularLinkedList
{
    public class SinglyCircularLinkedList
    {
        public Node Tail;
        private int count = 0;

        public int GetCount()
        {
            return count;
        }

        public string Print()
        {
            if (count == 0)
            {
                return string.Empty;
            }

            return Print(Tail.Next);
        }

        public string Print(Node node)
        {
            if (count == 0)
            {
                return string.Empty;
            }

            string result = "";
            Node current = node;
            do
            {
                result += current.Value + " ";
                current = current.Next;
            } while (current != node);

            return result;
        }

        public Node Find(int key)
        {
            if (count == 0)
            {
                return null;
            }

            Node current = Tail;
            do
            {
                if (current.Value == key)
                {
                    return current;
                }

                current = current.Next;
            } while (current != Tail);

            return null;
        }

        public void PushBack(int item)
        {
            Node newNode = new Node(item);

            if (count == 0)
            {
                InsertNodeToEmptyList(newNode);
            }
            else
            {
                AddAfterInternal(Tail, newNode);
                Tail = newNode;
            }
        }

        public void PushFront(int item)
        {
            Node newNode = new Node(item);
            if (count == 0)
            {
                InsertNodeToEmptyList(newNode);
            }
            else
            {
                AddAfterInternal(Tail, newNode);
            }
        }


        public void AddAfter(Node node, int item)
        {
            Node newNode = new Node(item);

            AddAfterInternal(node, newNode);
            if (node == Tail)
            {
                Tail = newNode;
            }
        }

        public void RemoveFirst()
        {
            RemoveAfterNodeInternal(Tail);
        }

        public void RemoveLast()
        {
            RemoveNode(Tail);
        }

        public void RemoveNode(Node node)
        {
            if (count == 0)
            {
                throw new Exception("Список пуст");
            }

            Node current = node;
            while (current.Next != node)
            {
                current = current.Next;
            }

            RemoveAfterNodeInternal(current);
        }


        private void RemoveAfterNodeInternal(Node node)
        {
            if (count == 0)
            {
                throw new Exception("Список пуст");
            }

            if (count == 1)
            {
                Tail = null;
            }
            else
            {
                if (node.Next == Tail)
                {
                    Tail = node;
                }

                node.Next = node.Next.Next;
            }

            count--;
        }

        private void InsertNodeToEmptyList(Node node)
        {
            node.Next = node;
            Tail = node;
            count++;
        }

        private void AddAfterInternal(Node node, Node newNode)
        {
            newNode.Next = node.Next;
            node.Next = newNode;
            count++;
        }


        // методы с заданий
        public Node FindLast(int key)
        {
            if (count == 0)
            {
                return null;
            }

            Node current = Tail.Next;
            Node last = null;
            do
            {
                if (current.Value == key)
                {
                    last = current;
                }

                current = current.Next;
            } while (current != Tail.Next);

            return last;
        }

        public void AddBefore(Node node, int item)
        {
            Node newNode = new Node(item);
            Node current = node;
            while (current.Next != node)
            {
                current = current.Next;
            }

            AddAfterInternal(current, newNode);
        }


        public bool Remove(int item)
        {
            // реализуйте данный метод
            return true;
        }

        public bool RemoveLast(int item)
        {
            return true;
        }
    }
}