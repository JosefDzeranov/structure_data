using System;
using System.Collections.Generic;

namespace SimpleHashTable
{
    public class SimpleHashTable
    {
        private const int N = 117;
        private List<Item>[] items;

        public SimpleHashTable()
        {
            this.items = new List<Item>[N];
            for (int i = 0; i < items.Length; i++)
            {
                items[i] = new List<Item>();
            }
        }

        public void Add(int key, int value)
        {
            var hashCode = GetHashCode(key);
            var newItem = new Item(key, value);
            var itemsWithSameHashCode = items[hashCode];

            // проверка дупликатов
            foreach (var item in itemsWithSameHashCode)
            {
                if (item.Key == key)
                {
                    throw new ArgumentException("Ключ " + key + " уже есть в таблице");
                }
            }

            itemsWithSameHashCode.Add(newItem);
        }


        public int Search(int key)
        {
            var hashCode = GetHashCode(key);
            foreach (var item in items[hashCode])
            {
                if (item.Key == key)
                {
                    return item.Value;
                }
            }

            throw new Exception("Элемента с ключом " + key + " не существует в таблице");
        }

        public void Delete(int key)
        {
            var hashCode = GetHashCode(key);
            var itemsWithSameHashCode = items[hashCode];

            for (var i = 0; i < itemsWithSameHashCode.Count; i++)
            {
                var item = itemsWithSameHashCode[i];
                if (item.Key == key)
                {
                    itemsWithSameHashCode.RemoveAt(i);
                    return;
                }
            }
        }

        public string Print()
        {
            var result = "";
            foreach (var list in items)
            {
                foreach (var item in list)
                {
                    result += item.Key + " " + item.Value + "\n";
                }
            }

            return result;
        }

        private int GetHashCode(int key)
        {
            return key % N;
        }
    }
}