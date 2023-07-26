using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace propertiesexfour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            Customer customer2 = new Customer();

            Console.WriteLine("ENTER TAX");

            Console.WriteLine("**customer one**");
            Console.WriteLine("Enter ID:");
            customer.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name:");
            customer.Name = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Customer details:");
            Console.WriteLine("ID: " + customer.Id + "\nName: " + customer.Name);

            Console.WriteLine("");
            Console.WriteLine("**customer two**");
            Console.WriteLine("Enter ID:");
            customer2.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name:");
            customer2.Name = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Customer details:");
            Console.WriteLine("ID: " + customer2.Id + "\nName: " + customer2.Name);

            Console.ReadKey();

        }
    }
}
