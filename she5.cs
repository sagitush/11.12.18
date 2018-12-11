using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sheela5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            cefel(a);
            int cefel1 = cefel(a);
            Console.WriteLine(cefel1);
            Console.WriteLine( cefel(a: 1, c: 10));
        }

        private static int cefel(int a, int b=1, int c=-1)
        {
            int d = a * b * c;
            return d;
        }
    }
}
