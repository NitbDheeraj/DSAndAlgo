using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAlgorithms.Tries
{
    public class TrieNode
    {
        static readonly int _alphabetSize = 26;
        public char _data;
        public bool _is_End_Of_String;
        public TrieNode[] _children = new TrieNode[_alphabetSize];

        public TrieNode()
        {
            _is_End_Of_String = false;

            for (int i = 0; i < _alphabetSize; i++)
                _children[i] = null;

        }

        
    }
}
