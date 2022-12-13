using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriorityExpiryCache
{

    /*
     * The PriorityExpiryCache has the following methods that can be invoked:

        get(String key)
        put(String key, String value, int priority, int expiry)
        evict(int currentTime)
        Rules:
        If an expired item is available. Remove it. If multiple items have the same expiry, removing any one suffices.

        If condition #1 can't be satisfied, remove an item with the least priority.

        If more than one item satisfies condition #2, remove the least recently used one.

     */



   /*    - For Get we want the time complexity to be O(1). 
    Since we needed a fast lookup, the best data structure to use is a Dictionary.
    Hence, we are using a dictionary to store the key and the pointer to the cache slot it is stored in. */

    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class PriorityExpiryCache
    {
        private int _capacity;

        private Dictionary<string, LinkedListNode<CacheItem>> _keyToItemMap;
        //Can use doubly linked list here
        private Dictionary<int, LinkedList<CacheItem>> _priorityToListMap;
        private PriorityQueue<LinkedListNode<CacheItem>> _minExpiryHeap;
        private PriorityQueue<LinkedListNode<CacheItem>> _minPriorityHeap;

        public PriorityExpiryCache(int capacity)
        {
            _keyToItemMap = new Dictionary<string, LinkedListNode<CacheItem>>();
            _minExpiryHeap = new PriorityQueue<LinkedListNode<CacheItem>>();
            _minPriorityHeap = new PriorityQueue<LinkedListNode<CacheItem>>();
            _priorityToListMap = new Dictionary<int, LinkedList<CacheItem>>();
            _capacity = capacity;
        }

        public string get(string key)
        {
            LinkedListNode<CacheItem> node = _keyToItemMap[key];
            if (node == null) return null;

            //Can use Doubly Linked list
            LinkedList<CacheItem> linkedList = _priorityToListMap[node.Value.getPriority()];
            linkedList.Remove(node);
            linkedList.AddFirst(node);

            return node.Value.getValue();
        }

        public void put(string key, string value, int priority, int expiryTime, int currentTime)
        {
            if (_keyToItemMap.Count() == _capacity) 
                    evict(currentTime);

            CacheItem item = new CacheItem(key, value, priority, expiryTime);

            LinkedListNode<CacheItem> node = new LinkedListNode<CacheItem>(item);

            if (_keyToItemMap.ContainsKey(key))
            {
                LinkedListNode<CacheItem> oldNode = _keyToItemMap[key];
                remove(oldNode);
            }

            _keyToItemMap.Add(key, node);
            _minExpiryHeap.Enqueue(node);
            _minPriorityHeap.Enqueue(node);
            if(!_priorityToListMap.ContainsKey(priority))
                _priorityToListMap.Add(priority, new LinkedList<CacheItem>());

            _priorityToListMap[priority].AddFirst(node);
        }

            public void evict(int currentTime)
        {
            if (_keyToItemMap.Count() == 0) return;

            LinkedListNode<CacheItem> node = _minExpiryHeap.Peek();
            if (currentTime > node.Value.getExpiryTime())
            {
                remove(node);
                return;
            }
            node = _minPriorityHeap.Peek();
            node = _priorityToListMap[node.Value.getPriority()].Last;
            remove(node);
        }

        //Remove items from all of the databases
        private void remove(LinkedListNode<CacheItem> node)
        {
            _keyToItemMap.Remove(node.Value.getKey());
            _minExpiryHeap.Dequeue(node);
            _minPriorityHeap.Dequeue(node);
            _priorityToListMap[node.Value.getPriority()].Remove(node);
        }

    }
    public class CacheItem
    {
        private string key;
        private string value;
        private int priority;
        private int expiryTime;

        public CacheItem(string key, string value, int priority, int expiryTime)
        {
            this.key = key;
            this.value = value;
            this.priority = priority;
            this.expiryTime = expiryTime;
        }

        public int getExpiryTime() => expiryTime;
        public int getPriority() => priority;
        public string getValue() => value;
        public string getKey() => key;
    }

    public class PriorityQueue<T>
    {
        List<T> _list = new List<T>();
        public T Peek()
        {
           return _list[0];
        }

        public void Dequeue(T item)
        {
            //Code to remove
        }

        public void Enqueue(T item)
        {
            //Code to Add
        }
    }

}
