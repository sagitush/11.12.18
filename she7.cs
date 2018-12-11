using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sheela7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] maarach1 = { -1, 60, 56, -67, 9, -6, 3 };
            int[] maarach2;
            int[] maarach3;
            seder(maarach1, out maarach2, out maarach3);
            PrintArray(maarach2);
            PrintArray(maarach3);
           

        }

        private static void PrintArray(int[] maarach)
        {
            for (int i = 0; i < maarach.Length; i++)
            {
                Console.Write($"{maarach[i]} ,");
            }

            Console.WriteLine();
        }

        private static void seder(int[] maarach1,out int[]maarach2, out int []maarach3)
        {
            int j = 0;
            int t = 0;
            maarach2 = new int[maarach1.Length];
            maarach3 = new int[maarach1.Length];
           
            for (int i = 0; i < maarach1.Length; i++)
            {
                if(maarach1[i]>=0)
                {
                    maarach2[j] = maarach1[i];
                    j++;
                }
                else 
                {
                    maarach3[t] = maarach1[i];
                    t++;
                }

            }
           

        }
    }
}
