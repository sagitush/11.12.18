using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sheela3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            Klita(out a,out b);
            Console.WriteLine(a);
            Console.WriteLine(b);
        }

        private static void Klita(out int a,out int b)
        {
            a = Convert.ToInt32(Console.ReadLine());
            b= Convert.ToInt32(Console.ReadLine());

        }
    }
}
