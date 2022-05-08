using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LRUCache
{
    //Least recently used.
    //Remove the item from cache which is rarely used.

    /*  Design a data structure which provides 2 operations – get and set.
        In get operation, take input “key”. If “key” is found in cache, then return value else return a miss(-1)
        In set operation, take input “key” and “value”. If cache has space, then store it.
        If no space, then remove an item from cache based on LRU algorithm. Then store “key” and “value” in cache.

    https://siddarthkanted.wordpress.com/2018/05/24/implement-lru-cache-in-c/
    */
    class Program
    {
        static void Main(string[] args)
        {
            LRUCache cache = new LRUCache(2);
            cache.Put(1, 10);
            cache.Put(5, 12);

            Console.WriteLine(cache.Get(5));

            Console.ReadLine();
        }
    }

    public class LRUCache
    {
        private LinkedList<KeyValuePair<int, int>> _list;
        private Dictionary<int, LinkedListNode<KeyValuePair<int, int>>> _map;
        private int _capacity;

        public LRUCache(int capacity)
        {
            this._capacity = capacity;
            _list = new LinkedList<KeyValuePair<int, int>>();
            _map = new Dictionary<int, LinkedListNode<KeyValuePair<int, int>>>();
        }

        /// <summary>
        /// In get operation, take input “key”. If “key” is found in cache, then return value else return a miss(-1)
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public int Get(int key)
        {
            if (!_map.ContainsKey(key)) return -1;
            var node = _map[key];
            _list.Remove(node);
            _map[key] = _list.AddFirst(node.Value);
            return node.Value.Value;
        }

        /// <summary>
        /// In set operation, take input “key” and “value”. If cache has space, then store it.
        /// If no space, then remove an item from cache based on LRU algorithm.Then store “key” and “value” in cache.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void Put(int key, int value)
        {
            if (_map.ContainsKey(key))
            {
                var node = _map[key];
                _list.Remove(node);
                _map[key] = _list.AddFirst(new KeyValuePair<int, int>(key, value));
            }
            else
            {
                if (_list.Count >= this._capacity)
                {
                    _map.Remove(_list.Last().Key);
                    _list.RemoveLast();
                }
                _map[key] = _list.AddFirst(new KeyValuePair<int, int>(key, value));
            }
        }
    }

}
