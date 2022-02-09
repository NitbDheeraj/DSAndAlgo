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
            HowSum hs = new HowSum();

            var res = hs.howSumDP(7, new int[] { 2, 4 });

            if (res == null)
                Console.WriteLine("null");
            else
                res.ForEach(x => Console.WriteLine(x));

            var res1 = hs.howSumDP(7, new int[] { 5, 3, 4, 7 });

            if (res1 == null)
                Console.WriteLine("null");
            else
                res1.ForEach(x => Console.WriteLine(x));

            var res2 = hs.howSumDP(300, new int[] { 14, 7 });

            if (res2 == null)
                Console.WriteLine("null");
            else
                res2.ForEach(x => Console.WriteLine(x));



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
