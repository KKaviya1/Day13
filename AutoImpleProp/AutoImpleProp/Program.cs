using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoImpleProp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            Console.WriteLine("Enter Id:");
            customer.Id=int.Parse(Console.ReadLine());
            Console.WriteLine("enter Name:");
            customer.Name=Console.ReadLine();
            Console.WriteLine("Enter customer city:");
            customer.City=Console.ReadLine();
            Console.WriteLine("Enter customer over draft limit:");
            customer.ODlimit=Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Customer details as follows!!");
            Console.WriteLine($"ID: {customer.Id} \nName: {customer.Name}");
            Console.WriteLine($"City: {customer.City} \nODLimit: {customer.ODlimit}");

            Console.ReadKey();

        }
    }
}
