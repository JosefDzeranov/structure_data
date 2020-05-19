using System;
using System.Collections.Generic;
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

    class Program
    {
        static void Main(string[] args)
        {
            #region FindLast

            // var line = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            //
            // var list = new SinglyCircularLinkedList();
            // foreach (var item in line)
            // {
            //     list.PushBack(int.Parse(item));
            // }
            //
            // int beforeLength = line.Length;
            // var beforePrinted = list.Print();
            //
            // var key = int.Parse(Console.ReadLine());
            // var node = list.FindLast(key);
            // Console.WriteLine(node?.Value);
            // Console.WriteLine(node?.Next?.Value);
            //
            // int afterRemoveLength = list.GetCount();
            // if (beforeLength != afterRemoveLength)
            //     throw new Exception("Метод \"FindLast\" изменяет кол-во элементов");
            //
            // var afterPrinted = list.Print();
            // if (beforePrinted != afterPrinted)
            //     throw new Exception("Метод \"FindLast\" изменяет элементы массива");

            #endregion

            #region AddBefore

            // var line = Console.ReadLine().Split();
            // var list = new SinglyCircularLinkedList();
            // for (int i = 0; i < line.Length; i++)
            // {
            //     list.PushBack(int.Parse(line[i]));
            // }
            //
            // int expectedLength = line.Length + 1;
            //
            // int key = int.Parse(Console.ReadLine());
            // var node = list.Find(key);
            //
            // int item = int.Parse(Console.ReadLine());
            // list.AddBefore(node, item);
            //
            // if (list.GetCount() != expectedLength)
            //     throw new Exception(
            //         "Кол-во элементво в списке после добавления должна быть на 1 больше, чем до добавления.");
            //
            // Console.WriteLine(list.Print());

            #endregion

            #region Remove

            // var line = Console.ReadLine().Split();
            // int beforeRemoveLength = line.Length;
            // var list = new SinglyCircularLinkedList();
            // foreach (var item in line)
            // {
            //     list.PushBack(int.Parse(item));
            // }
            //
            // var itemToRemove = int.Parse(Console.ReadLine());
            // var isRemove = list.Remove(itemToRemove);
            // Console.WriteLine(list.Print());
            //
            // int afterRemoveLength = list.GetCount();
            //
            // if (beforeRemoveLength == afterRemoveLength && isRemove)
            //     throw new Exception("Метод \"Remove\" возвращает неправильное значение");
            //
            // if (beforeRemoveLength != afterRemoveLength && !isRemove)
            //     throw new Exception("Метод \"Remove\" возвращает неправильное значение");

            #endregion

            #region RemoveLast
            // var line = Console.ReadLine().Split();
            // int beforeRemoveLength = line.Length;
            // var list = new SinglyCircularLinkedList();
            // foreach (var item in line)
            // {
            //     list.PushBack(int.Parse(item));
            // }
            // var itemToRemove = int.Parse(Console.ReadLine());
            // var isRemove = list.RemoveLast(itemToRemove);
            // Console.WriteLine(list.Print());
            //
            // int afterRemoveLength = list.GetCount();
            //
            // if (beforeRemoveLength == afterRemoveLength && isRemove)
            //     throw new Exception("Метод \"RemoveLast\" возвращает неправильное значение");
            //
            // if (beforeRemoveLength != afterRemoveLength && !isRemove)
            //     throw new Exception("Метод \"RemoveLast\" возвращает неправильное значение");
            #endregion
        }
    }
}