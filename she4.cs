using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sheela_4
{
    class Program
    {
        private static int numbers(params int[] arrayofnumbers)
        {
            int sum = arrayofnumbers[0];
            for (int i = 1; i < arrayofnumbers.Length; i++)
            {
                int azeret = 1;
                for (int j = 0; j <=i; j++)
                {
                    azeret = azeret * arrayofnumbers[i];

                }
                sum = sum + azeret;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(numbers(5,4,3,8));
        }
    }
}
