//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Assignment16
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            BankAccount account = new BankAccount("Viya");

//            account.Deposit(10000);
//            account.Withdraw(500);
//            account.Deposit(2000);

//            account.PrintAccountDetails();

//            Console.ReadKey();
//        }
//    }

//}




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment16
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter Account Holder's Name: ");
            string accountHolderName = Console.ReadLine();

            Console.Write("Enter Initial Balance: ");
            decimal initialBalance = Convert.ToDecimal(Console.ReadLine());

            BankAccount account = new BankAccount(accountHolderName, initialBalance);

            Console.Write("Enter Deposit Amount: ");
            decimal depositAmount = Convert.ToDecimal(Console.ReadLine());
            account.Deposit(depositAmount);

            Console.Write("Enter Withdrawal Amount: ");
            decimal withdrawalAmount = Convert.ToDecimal(Console.ReadLine());
            account.Withdraw(withdrawalAmount);
            Console.WriteLine("");

            account.PrintAccountDetails();
            Console.ReadKey();
        }
    }

}