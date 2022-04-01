using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming.CanCountAllConstruct
{
    //Given a target string and an array of strings (wordbank), write a function that returns a 2D array containing all of the ways 
    // in which target can be constructed using elements of word bank array.

    //you may reuse elements of wordbank as many times as needed.

    public class AllConstruct
    {
        public string[][] allConstruct(string target, string[] wordbank)
        {
            if (string.IsNullOrEmpty(target))
                return null;

            string[][] res = Array.Empty<string[]>();

            foreach (var item in wordbank)
            {
                if (target.IndexOf(item) == 0)
                {
                    string remainder = target.Substring(item.Length);
                    var constructWays = allConstruct(remainder, wordbank);

                    if(constructWays == null)
                    {
                        constructWays = new string[][] { new[] { item } };
                        res.Append(new[] { item }).ToArray();
                        continue;
                    }

                    foreach (var way in constructWays)
                    {
                        res.Append(way.Append(item).ToArray());
                    }
                }
            }

            return res;
        }
    }
}
