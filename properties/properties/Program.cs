using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //example - 01
            //Customer customer = new Customer();
            //Console.WriteLine("**Default Values**");
            //Console.WriteLine($"Customer ID: {customer.Id} Name: {customer.Name} MembershipEndDate {customer.MEndDate}");

            //Console.WriteLine("enter customer ID");
            //customer.Id=int.Parse(Console.ReadLine());
            //Console.WriteLine("enter customer name");
            //customer.Name=Console.ReadLine();
            //Console.WriteLine("enter customer memebership end date");
            //customer.MEndDate=DateTime.Parse(Console.ReadLine());
            //Console.WriteLine("stored record as follows!!");

            //Console.WriteLine($"Customer ID: {customer.Id} Name: {customer.Name} MembershipEndDate {customer.MEndDate}");



            //example - 02--->read only
            //Customer customer = new Customer(3,"viya",new DateTime(day: 10, month: 05, year: 2024));
            //Console.WriteLine("customer details as follows");
            //Console.WriteLine($"customer ID:{customer.Id} Name:{customer.Name} MembershipEndDate:{customer.MEndDate}");


            //example - 03--->write only
            Customer customer = new Customer(3, "viya", new DateTime(day: 10, month: 05, year: 2024));
            Console.WriteLine("customer details as follows");
            Console.WriteLine($"customer ID:{customer.Id} Name:{customer.Name} MembershipEndDate:{customer.MEndDate}");
            customer.Comment = "I am delighted with the services provided by the vendor.";
            customer.ReadComment("admin@123");



            Console.ReadKey();
        }

    }
}
