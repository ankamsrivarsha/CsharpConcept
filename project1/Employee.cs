using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    internal class Employee
    {
        public int empid;
        public string ename;
        public double esal;
        public static string companyName;

        public static void Main5(String[] args)
        {
            Employee.companyName = "fujitsu";
            Employee emp = new Employee();
            Employee emp2 = new Employee();
            Employee emp3 = new Employee();

            emp.empid = 101;
            emp.ename = "raju";
            emp.esal = 20000;

            emp2.empid = 102;
            emp2.ename = "rani";
            emp2.esal = 400000;

     
            static void Display(Employee e)
            {
                Console.WriteLine(e.empid);
                Console.WriteLine(e.ename);
                Console.WriteLine(e.esal);
                Console.WriteLine(Employee.companyName);

            }
            Display(emp);
            Display(emp2);


        }
    }
}
