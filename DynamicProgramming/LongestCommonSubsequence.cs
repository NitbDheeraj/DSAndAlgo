using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming
{
    class LongestSubsequence
    {

        public static String LCM = "";
        public static String answer = "";
        static void Main(string[] args)
        {
            String subseqX = "ACCGGTCGAGTGCGCGGAAGCCGGCCGAA";
            String subseqY = "GTCGTTCGGAATGCCGTTGCTCTGTAAA";

            String x = "AGGCATT";
            String y = "GACGAT";


            String w = "ACCAT";
            String q = "ACGAT";

            Console.WriteLine("Substring 1: " + subseqX + "\n" + "substring 2: " + subseqY);
            //finds the LCS
            String[,] check0 = lengthLCS(subseqX, subseqY);
            //prints the LCS
            String lcs = printLCS(check0, subseqX, subseqY, subseqX.Length, subseqY.Length);
            Console.WriteLine(lcs);
            Console.WriteLine("LCS Length is: " + lcs.Length);

            Console.ReadLine();

        }

        private static string[,] lengthLCS(string subseqX, string subseqY)
        {
            char[] b = subseqX.ToCharArray();
            char[] a = subseqY.ToCharArray();
            int m = b.Length;
            int n = a.Length;

            int[,] LCS = new int[m + 1, n + 1];
            string[,] opt = new string[m + 1, n + 1];

            for (int i = 0; i <= m; i++)
            {
                LCS[i, 0] = 0;
                opt[i, 0] = "0";
            }
            for (int i = 0; i <= n; i++)
            {
                LCS[0, i] = 0;
                opt[0, i] = "0";
            }

            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (b[i - 1] == a[j - 1])
                    {
                        LCS[i, j] = LCS[i - 1, j - 1] + 1;
                        opt[i, j] = "diagonal";
                    }
                    else
                    {
                        LCS[i, j] = Math.Max(LCS[i - 1, j], LCS[i, j - 1]);  //deciding whether to use the entry above or diagonal
                        if (LCS[i, j] == LCS[i - 1, j])
                        {
                            opt[i, j] = "up";
                        }
                        else //so when LCS[i][j] = LCS[i][j-1]
                            opt[i, j] = "left";
                    }
                }
            }

            return opt;
        }

        private static String printLCS(String[,] opt, String subseqX, String subseqY, int i, int j)
        {

            String x = opt[i, j];
            char[] m = subseqX.ToCharArray();

            if (i == 0 || j == 0)
                return "";

            if (opt[i, j] == "diagonal")
            {
                answer = m[i - 1] + answer;
                printLCS(opt, subseqX, subseqY, i - 1, j - 1);
            }
            else if (opt[i, j] == "left")
            {
                printLCS(opt, subseqX, subseqY, i, j - 1);
            }
            else if (opt[i, j] == "up")
            {
                printLCS(opt, subseqX, subseqY, i - 1, j);
            }
            x = opt[i, j];

            return answer;
        }
    }
}
