using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sheela_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a =3;
            int b=2;
            Peula(ref a,ref b);
            Console.WriteLine(a);
            Console.WriteLine(b);
        }

        private static void Peula(ref int a,ref int b)
        {
            a = a + 1;
            b = b * 2;
        }
    }
}
