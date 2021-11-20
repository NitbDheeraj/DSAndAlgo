using StringAlgorithms.Tries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {

            TriesTest test = new TriesTest();

            test.TestTrie();

            Console.ReadLine();
        }
    }
}
