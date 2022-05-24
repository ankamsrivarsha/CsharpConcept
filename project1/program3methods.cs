using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    internal class Program3methods

    {
        static double Area(int r)
        {
            double output = 3.14 * r * r;
            return output;
        }
        public static void Main(String[] args)
        {
            double res = Program3methods.Area(1);
            Console.WriteLine(res);

            double re = Program3methods.Area(2);
            Console.WriteLine(re);
        }
    }
}
