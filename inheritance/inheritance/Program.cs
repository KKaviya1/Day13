using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Developer dev = new Developer();
            Console.WriteLine("Default values");
            Console.WriteLine("ID:\t"+dev.Id);
            Console.WriteLine("Name:\t"+dev.Name);
            Console.WriteLine("Salary:\t"+dev.Salary);
            Console.WriteLine("Project:\t"+dev.Project);
            Console.WriteLine("Domain:\t"+dev.Domain);

            Console.ReadKey();
        }
    }
}
