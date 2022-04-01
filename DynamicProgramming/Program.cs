using DynamicProgramming.CanCountAllConstruct;
using DynamicProgramming.CanCountConstruct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            AllConstruct ac = new AllConstruct();
            var res = ac.allConstruct("abcdef", new string[] { "ab", "abc", "cd", "def", "abcd", "ef" });

            foreach (var item in res)
            {
                foreach (var way in item)
                {
                    Console.Write(way);
                }
                Console.WriteLine("\n");
            }

            //CountConstruct cc = new CountConstruct();

            //Console.WriteLine(cc.countConstructDP("abcdef", new string[] { "ab", "abc", "cd", "def", "abcd", "ef" })); 
            //Console.WriteLine(cc.countConstructDP("skateboard", new string[] { "bo", "rd", "ate", "t", "ska", "boar" }));
            //Console.WriteLine(cc.countConstructDP("potato", new string[] { "po", "ta", "to", "t", "ska", "boar" }));
            //Console.WriteLine(cc.countConstructDP("purple", new string[] { "purp", "p", "ur", "le", "purpl", "boar" })); //2
            //Console.WriteLine(cc.countConstructDP("eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeef", new string[] { "e", "ee", "eee", "eeee" })); //0

            //CanConstruct cc = new CanConstruct();

            //Console.WriteLine(cc.canConstructDP("abcdef", new string[] { "ab", "abc", "cd", "def", "abcd" }));
            //Console.WriteLine(cc.canConstructDP("skateboard", new string[] { "bo", "rd", "ate", "t", "ska","boar" }));
            //Console.WriteLine(cc.canConstructDP("potato", new string[] { "po", "ta", "to", "t", "ska", "boar" }));
            //Console.WriteLine(cc.canConstructDP("eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeef", new string[] { "e","ee", "eee", "eeee" }));

            //BestSum bs = new BestSum();

            //var res = bs.bestSumDP(8, new int[] { 2, 3, 5 });

            //if (res == null)
            //    Console.WriteLine("null");
            //else
            //    res.ForEach(x => Console.Write(x));

            //var res1 = bs.bestSumDP(7, new int[] { 5, 3, 4, 7 });

            //if (res1 == null)
            //    Console.WriteLine("null");
            //else
            //    res1.ForEach(x => Console.Write(x));

            //var res2 = bs.bestSumDP(100, new int[] { 1, 2, 5, 25 });

            //if (res2 == null)
            //    Console.WriteLine("null");
            //else
            //    res2.ForEach(x => Console.Write(x));


            //HowSum hs = new HowSum();

            //var res = hs.howSumDP(7, new int[] { 2, 4 });

            //if (res == null)
            //    Console.WriteLine("null");
            //else
            //    res.ForEach(x => Console.WriteLine(x));

            //var res1 = hs.howSumDP(7, new int[] { 5, 3, 4, 7 });

            //if (res1 == null)
            //    Console.WriteLine("null");
            //else
            //    res1.ForEach(x => Console.WriteLine(x));

            //var res2 = hs.howSumDP(300, new int[] { 14, 7 });

            //if (res2 == null)
            //    Console.WriteLine("null");
            //else
            //    res2.ForEach(x => Console.WriteLine(x));



            //CanSum cs = new CanSum();

            //Console.WriteLine(cs.canSumDP(7, new int[] { 2, 4 }));
            //Console.WriteLine(cs.canSumDP(7, new int[] { 5, 3, 4, 7 }));
            //Console.WriteLine(cs.canSumDP(300, new int[] { 14, 7 }));

            ////Testing grid traveller
            //GridTraveller gt = new GridTraveller();
            ////this is 1
            //Console.WriteLine(gt.GridTravellerWaysDP(1, 1));

            ////this is 3
            //Console.WriteLine(gt.GridTravellerWaysDP(3, 2));

            ////this is 3
            //Console.WriteLine(gt.GridTravellerWaysDP(2, 3));

            ////this is 6
            //Console.WriteLine(gt.GridTravellerWaysDP(3, 3));

            ////this is 2333606220
            //Console.WriteLine(gt.GridTravellerWaysDP(18, 18));

            Console.ReadLine();
        }
    }
}
