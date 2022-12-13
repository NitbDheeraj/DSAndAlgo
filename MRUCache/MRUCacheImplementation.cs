using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRUCache
{

    public class MRUAlgorithm<K, V>
    {
        private int _capacity;
        public MRUAlgorithm(int capacity)
        {
            _capacity = capacity;
        }
        private Dictionary<K, LinkedListNode<KeyValuePair<K, V>>> cacheMap = new Dictionary<K, LinkedListNode<KeyValuePair<K, V>>>();
        private LinkedList<KeyValuePair<K, V>> list = new LinkedList<KeyValuePair<K, V>>();
        public V Get(K key)
        {
            LinkedListNode<KeyValuePair<K, V>> node;
            if (cacheMap.TryGetValue(key, out node))
            {
                V value = node.Value.Value;
                list.Remove(node);
                list.AddFirst(node);
                return value;
            }
            return default(V);
        }
        public void Add(K key, V val)
        {
            if (cacheMap.Count >= _capacity)
            {
                RemoveFirst();
            }
            LinkedListNode<KeyValuePair<K, V>> nodeFound;
            if (cacheMap.TryGetValue(key, out nodeFound))
            {
                list.Remove(nodeFound);
                cacheMap.Remove(nodeFound.Value.Key);
            }
            KeyValuePair<K, V> cacheItem = new KeyValuePair<K, V>(key, val);
            LinkedListNode<KeyValuePair<K, V>> node = new LinkedListNode<KeyValuePair<K, V>>(cacheItem);
            list.AddLast(node);
            cacheMap.Add(key, node);
        }

        private void RemoveFirst()
        {
            LinkedListNode<KeyValuePair<K, V>> node = list.First;
            list.RemoveFirst();
            cacheMap.Remove(node.Value.Key);
        }
    }
}
