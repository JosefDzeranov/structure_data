using System;
using System.Collections.Generic;

namespace SetOnArray
{
    public class SetOnArray
    {
        public List<int> Items { get; }

        public SetOnArray()
        {
            Items = new List<int>();
        }

        public string Print()
        {
            string result = "";
            foreach (var item in Items)
            {
                result += item + " ";
            }

            return result;
        }

        public bool Empty()
        {
            return Items.Count == 0;
        }

        public bool Add(int item)
        {
            // если множество НЕ содержит такой элемент, то добавляем
            if (!Items.Contains(item))
            {
                Items.Add(item);
                return true;
            }

            return false;
        }

        public bool Remove(int item)
        {
            return Items.Remove(item);
        }

        public void Union(SetOnArray otherSet)
        {
            if (otherSet == null)
            {
                throw new Exception("Множество не должен быть пустым");
            }

            foreach (var item in otherSet.Items)
            {
                Add(item);
            }
        }

        public void Intersect(SetOnArray otherSet)
        {
            if (otherSet == null)
            {
                throw new Exception("Множество не должен быть пустым");
            }

            List<int> forRemoveItems = new List<int>();
            foreach (var item in Items)
            {
                if (!otherSet.Items.Contains((item)))
                {
                    forRemoveItems.Add(item);
                }
            }

            foreach (var removeItem in forRemoveItems)
            {
                Remove(removeItem);
            }
        }

        public void Difference(SetOnArray otherSet)
        {
            if (otherSet == null)
            {
                throw new Exception("Множество не должен быть пустым");
            }

            foreach (var item in otherSet.Items)
            {
                Remove(item);
            }
        }

        public bool IsSubset(SetOnArray otherSet)
        {
            if (Items.Count < otherSet.Items.Count)
                return false;
            
            var newSet = new SetOnArray();
            foreach (var item in Items)
            {
                newSet.Add(item);
            }
            newSet.Difference(otherSet);
            return newSet.Empty();
        }
    }
}