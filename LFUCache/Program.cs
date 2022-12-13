using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LFUCache
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class LFUCache
    {
        private int capacity;
        private int min;
        private Dictionary<int, int> values;
        private Dictionary<int, int> counts;
        private Dictionary<int, LinkedList<int>> countTracker;

        public LFUCache(int capacity)
        {
            this.capacity = capacity;
            this.values = new Dictionary<int, int>();
            this.counts = new Dictionary<int, int>();
            this.countTracker = new Dictionary<int, LinkedList<int>>();
            min = -1;
        }

        public int Get(int key)
        {
            if (!values.ContainsKey(key))
                return -1;

            IncrementCount(key);
            return values[key];
        }

        public void Put(int key, int value)
        {
            if (values.ContainsKey(key))
            {
                IncrementCount(key);
            }
            else
            {
                if (values.Count >= capacity)
                {
                    RemoveLFU();
                }
                min = 1;
                AddToCountTracker(key, 1);
            }
            values[key] = value;
        }

        public void RemoveLFU()
        {
            int lfukey = countTracker[min].First.Value;
            countTracker[min].RemoveFirst();
            values.Remove(lfukey);
        }

        public void IncrementCount(int key)
        {
            int count = counts[key];
            countTracker[count].Remove(key);
            if (min == count && countTracker[count].Count == 0)
            {
                min++;
            }

            AddToCountTracker(key, count + 1);
        }

        public void AddToCountTracker(int key, int count)
        {
            counts[key] = count;
            if (!countTracker.ContainsKey(count))
                countTracker.Add(count, new LinkedList<int>());

            countTracker[count].AddLast(key);
        }
    }
}
