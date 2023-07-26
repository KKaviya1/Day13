using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    public class Employee
    {
        public Employee() 
        {
            Console.WriteLine("employee Constructor!!");
            id = -1;
            name = "not given";
            salary = 0.0;

        }
        private int id;
           
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string name;
        public string Name
         {
            get { return name; }
            set { name = value; }
        }
        private double salary;
        public double Salary
        {
            get { return salary; } 
            set { salary = value; }
        }

    }
}
