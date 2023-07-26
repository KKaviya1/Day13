using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace properties
{
    //example - 01

    //public class customer
    //{
    //    int id;
    //    string name;
    //    datetime menddate;
    //    public customer()
    //    {
    //        id = -1;
    //        name = "not given";
    //        menddate = datetime.now;
    //    }
    //    public int id { get { return id; } set { id = value; } }
    //    public string name { get { return name; } set { name = value; } }
    //    public datetime menddate { get { return menddate; } set { menddate = value; } }
    //}


    //example - 02
    public class Customer
    {
        int id;
        string name;
        DateTime mEndDate;
        string comment;
        public Customer(int id, string name, DateTime mEndDate)
        {
            Console.WriteLine("customer constructor call");
            this.id = id;
            this.name = name;
            this.mEndDate = mEndDate;
        }
        public int Id { get { return id; } }
        public string Name { get { return name; }  }
        public DateTime MEndDate { get { return mEndDate; } }
        public string Comment { set { comment = value; } }
        public void ReadComment(string passCode)
        {
            if (passCode == "admin@123")
            {
                Console.WriteLine("Comment is: " + comment);
            }
        }

    }
}






