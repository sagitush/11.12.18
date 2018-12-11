using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._12._18
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 18;
            int b = 5;
            if (Booleani(a, b)==true)
            {
                Console.WriteLine("no module");
            }
            else
            Console.WriteLine("some module");


        }

        private static bool Booleani(int a, int b)
        {
            bool mitchalek=true;
            if (a%b==0)
            {
               return mitchalek;
            }
            
            return !mitchalek;

        }
    }
}
