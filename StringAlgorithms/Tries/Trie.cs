using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAlgorithms.Tries
{
    public class Trie
    {
        static TrieNode _root;

        public void InsertInTrie(string s)
        {
            int _index;

            TrieNode _p = _root;

            for (int i = 0; i < s.Length; i++)
            {
                _index = s[i] - 'a';

                if (_p._children[_index] == null)
                    _p._children[_index] = new TrieNode();

                _p = _p._children[_index];
            }

            _p._is_End_Of_String = true;
        }

        public bool SearchInATrie(string s)
        {
            int _index;

            TrieNode _p = _root;

            for (int i = 0; i < s.Length; i++)
            {
                _index = s[i] - 'a';

                if (_p._children[_index] == null)
                    return false;

                _p = _p._children[_index];
            }

            return _p._is_End_Of_String;
        }
    }
}
