using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAlgorithms
{
    //Given an array of strings, find all anagram pairs in the given array.
    public class GroupAnagrams
    {
        public IList<IList<string>> GroupAnagramsInListOfString(string[] strs)
        {
            if (strs == null || strs.Length == 0)
                return new List<IList<string>>();

            List<IList<string>> res = new List<IList<string>>();
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

            foreach (var str in strs)
            {
                string cur = new string(str.OrderBy(x => x).ToArray());

                if (!dict.ContainsKey(cur))
                    dict.Add(cur, new List<string>());

                dict[cur].Add(str);
            }

            foreach (var item in dict.Values)
                res.Add(item);

            return res;
        }

        public IList<IList<string>> GroupAnagramsInListOfString1(string[] strs)
        {
            Dictionary<string, List<string>> d = new Dictionary<string, List<string>>();

            foreach (var w in strs)
            {
                int[] arr = new int[26];
                foreach (var c in w)
                    arr[c - 'a']++;

                string key = string.Join(",", arr); //dictionary key is char count joined string
                if (d.ContainsKey(key))
                    d[key].Add(w); //store anagram words together
                else
                    d.Add(key, new List<string>() { w });

            }
            List<IList<string>> res = new List<IList<string>>();
            foreach (var v in d.Values)
                res.Add(v);

            return res;

        }
    }
}
