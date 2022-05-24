using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    internal class program1
    {
        static void Main1(String[] args)
        {
            int per = Convert.ToInt32(Console.ReadLine());
            //worked
            if(per >= 90)
            {
                Console.WriteLine("Grade is A");
            }
            if (per >= 80 && per <= 89)
            {
                Console.WriteLine("Grade is B");
            }
            if (per >= 60 && per <= 79)
            {
                Console.WriteLine("Grade is C");
            }
            if (per >= 45 && per <= 59)
            {
                Console.WriteLine("Grade is D");
            }
            if (per <= 45)
            {
                Console.WriteLine("Grade is F");
            }
        }
    }
}
