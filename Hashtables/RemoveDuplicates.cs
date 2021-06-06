using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashtables
{
    // Given an array of characters, give an algorithm for removing the duplicates.
    public class RemoveDuplicates
    {
        public char[] removeDuplicates(char[] input)
        {
            Dictionary<char, char> dict = new Dictionary<char, char>();
            List<char> returnList = new List<char>();
            foreach (var item in input)
            {
                if (!dict.ContainsKey(item))
                {
                    returnList.Add(item);
                    dict.Add(item, item);
                }
            }
            return returnList.ToArray();
        }
    }
}
