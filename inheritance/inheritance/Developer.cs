using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    public class Developer : Employee
    {
        string domain;
        string project;

        public Developer()
        {
            Console.WriteLine("Developer constructor call");
            domain = "not given";
            project = "not assign";
        }
        public string Domain
        {
            get { return domain; }
            set { domain = value; }
        }
        public string Project
        {
            get { return project; }
            set { project = value; }
        }
    }
}

