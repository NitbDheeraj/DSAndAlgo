using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAlgorithms.Tries
{
    public class TriesTest
    {
        public void TestTrie()
        {
            string[] keys = { "the", "a", "there", "answer", "any", "by", "bye", "their" };
            string[] output = { "Not present in trie", "Not Present in trie" };

            var root = new Trie();

            for (int i = 0; i < keys.Length; i++)
                root.InsertInTrie(keys[i]);

            if (root.SearchInATrie("the"))
                Console.WriteLine(output[1]);
            else
                Console.WriteLine(output[0]);
        }
        

    }
}
