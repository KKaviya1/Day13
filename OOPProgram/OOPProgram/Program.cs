using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            Employee employee2 = new Employee();
            Console.WriteLine("");
            Console.WriteLine("Enter employee one details");
            employee.Register();
            Console.WriteLine("");
            Console.WriteLine("Enter employee two details");
            employee2.Register();
            Console.WriteLine("");
            Console.WriteLine("Employee one display");
            employee.Display();
            Console.WriteLine("Employee two display");
            employee.Display();

            Console.ReadKey();
        }
    }
}
