//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Assignment16
//{ 
//        class BankAccount
//        {
//            private static int nextAccountNumber = 314056142;

//            public int AccountNumber { get; }
//            public string AccountHolderName { get; set; }
//            private decimal Balance { get; set; }

//            public BankAccount(string accountHolderName)
//            {
//                AccountNumber = nextAccountNumber++;
//                AccountHolderName = accountHolderName;
//                Balance = 0;
//            }

//            public void Deposit(decimal amount)
//            {
//                Balance += amount;
//                Console.WriteLine($"{amount:C} deposited into the account.-----> New balance: {Balance:C}");
//            }

//            public void Withdraw(decimal amount)
//            {
//                if (amount <= Balance)
//                {
//                    Balance -= amount;
//                    Console.WriteLine($"{amount:C} withdrawn from the account.-----> New balance: {Balance:C}");
//                }
//                else
//                {
//                    Console.WriteLine("Insufficient balance. Withdrawal failed.");
//                }
//            }

//            public void PrintAccountDetails()
//            {
//                Console.WriteLine();
//                Console.WriteLine("**Account Details**");
//                Console.WriteLine($"Account Number: {AccountNumber}");
//                Console.WriteLine($"Account Holder Name: {AccountHolderName}");
//                Console.WriteLine($"Total Bank Balance: {Balance:C}");
//            }
//        }

//    }






using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment16
{
    class BankAccount
    {
        private static int nextAccountNumber = 314526579;

        public int AccountNumber { get; }
        public string AccountHolderName { get; set; }
        private decimal Balance { get; set; }

        public BankAccount(string accountHolderName, decimal initialBalance = 0)
        {
            AccountNumber = nextAccountNumber++;
            AccountHolderName = accountHolderName;
            Balance = initialBalance;
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
            Console.WriteLine($"{amount:C} deposited into the account. New balance: {Balance:C}");
        }
        public void Withdraw(decimal amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"{amount:C} withdrawn from the account. New balance: {Balance:C}");
            }
            else
            {
                Console.WriteLine("Insufficient balance. Withdrawal failed.");
            }
        }

        public void PrintAccountDetails()
        {
            Console.WriteLine("**Account Details**");
            Console.WriteLine($"Account Number: {AccountNumber}");
            Console.WriteLine($"Account Holder Name: {AccountHolderName}");
            Console.WriteLine($"Total Bank Balance: {Balance:C}");
        }
    }
}


