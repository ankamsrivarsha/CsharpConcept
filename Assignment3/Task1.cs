using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Task1
    {
        public int studentRollno;
        public string studentName;
        public string studentMailId;
        public double studentMarks;
        public static string schoolName;

        static void Mained(String[] args)
        {
            Task1.schoolName = "Global School";
            Task1 t1 = new Task1();
            Task1 t2 = new Task1();
            Task1 t3 = new Task1();

            t1.studentRollno = 1001;
            t1.studentName = "jack";
            t1.studentMailId = "jack@gmail.com";
            t1.studentMarks = 45.2;

            t2.studentRollno = 1002;
            t2.studentName = "peter";
            t2.studentMailId = "peter@gmail.com";
            t2.studentMarks = 85.2;

            t3.studentRollno = 1003;
            t3.studentName = "Mark";
            t3.studentMailId = "mark@gmail.com";
            t3.studentMarks = 56.5;

            Display(t1);
            Display(t2);
            Display(t3);

             static void Display(Task1 t)
            {
                Console.WriteLine(t.studentRollno);
                Console.WriteLine(t.studentName);
                Console.WriteLine(t.studentMailId);
                Console.WriteLine(t.studentMarks);
                Console.WriteLine(Task1.schoolName);
                Console.WriteLine("**************************");
            }
        }
    }
}
