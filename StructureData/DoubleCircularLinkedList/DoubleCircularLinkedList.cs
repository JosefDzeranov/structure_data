using System;
using DoubleLinkedList;

namespace DoubleCircularLinkedList
{
    public class DoubleCircularLinkedList
    {
        public Node Head;
        private int count = 0;

        public int GetCount()
        {
            return count;
        }


        public string Print(bool forward)
        {
            if (count == 0)
            {
                return string.Empty;
            }

            if (forward)
            {
                return Print(Head, forward);
            }

            return Print(Head.Previous, forward);
        }

        public string Print(Node node, bool forward)
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

                if (forward)
                    current = current.Next;
                else
                    current = current.Previous;
            } while (current != node);

            return result;
        }


        public Node Find(int key)
        {
            if (count == 0)
            {
                return null;
            }

            Node current = Head;
            do
            {
                if (current.Value == key)
                {
                    return current;
                }

                current = current.Next;
            } while (current != Head);

            return null;
        }

        private void AddBeforeInternal(Node node, Node newNode)
        {
            newNode.Next = node;
            newNode.Previous = node.Previous;
            node.Previous.Next = newNode;
            node.Previous = newNode;
            count++;
        }

        private void InsertNodeToEmptyList(Node node)
        {
            node.Next = node;
            node.Previous = node;
            Head = node;
            count++;
        }

        public void AddBefore(Node node, int item)
        {
            Node newNode = new Node(item);

            AddBeforeInternal(node, newNode);
            if (node == Head)
            {
                Head = newNode;
            }
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
                AddBeforeInternal(Head, newNode);
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
                AddBeforeInternal(Head, newNode);
                Head = newNode;
            }
        }


        public void RemoveNode(Node node)
        {
            if (count == 0)
            {
                throw new Exception("Список пуст");
            }

            if (node.Next == node)
            {
                Head = null;
            }
            else
            {
                node.Next.Previous = node.Previous;
                node.Previous.Next = node.Next;
                if (Head == node)
                {
                    Head = node.Next;
                }
            }

            count--;
        }

        public void RemoveFirst()
        {
            RemoveNode(Head);
        }

        public void RemoveLast()
        {
            if (count == 0)
            {
                throw new Exception("Список пуст");
            }

            RemoveNode(Head.Previous);
        }

        // Задачи
        public Node FindLast(int key)
        {
            if (count == 0)
            {
                return null;
            }

            Node current = Head.Previous;
            do
            {
                if (current.Value == key)
                {
                    return current;
                }

                current = current.Previous;
            } while (current != Head.Previous);

            return null;
        }


        public void AddAfter(Node node, int item)
        {
            if (node == null)
                return;

            AddBeforeInternal(node.Next, new Node(item));
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
    }
}