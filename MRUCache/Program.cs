using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRUCache
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class MRUCacheAlgorithm
    {
        Dictionary<int, int> _map = new Dictionary<int, int>();
        LinkedList<int> _list = new LinkedList<int>();
        int _capcaity;

        public MRUCacheAlgorithm(int capacity)
        {
            this._capcaity = capacity;
        }

        public int Get(int key)
        {
            if (!_map.ContainsKey(key))
                return -1;

            _list.Remove(key);
            _list.AddFirst(key);

            return _map[key];
        }

        public void Put(int key, int val)
        {
            if (_map.ContainsKey(key))
            {
                _list.Remove(key);
                _list.AddLast(key);
                _map[key] = val;
            }
            else
            {
                if (_map.Count() >= _capcaity)
                {
                    _list.RemoveFirst();
                    _map.Remove(key);
                    _list.AddLast(key);
                }
                _map.Add(key, val);
            }
        }
    }

}
