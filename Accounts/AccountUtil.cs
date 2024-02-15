using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounts
{
    internal class AccountUtil
    {
        public static void Display(List<Account> accounts) {
            Console.WriteLine("\n==============Accounts======================");
              foreach (var account in accounts)
            {
                Console.WriteLine(account);
            }
        }
        public static void Deposit(List<Account> accounts, double amount)
        {
            Console.WriteLine("\n==============Deposits to Accounts======================");
            foreach (var account in accounts)
            {
                if (account.Deposit(amount))
                    Console.WriteLine($"Deposited {amount} to {account}");
                else Console.WriteLine($"faild deposited of {amount} to {account}");
            }
        }
            public static void Withdraw(List<Account> accounts, double amount)
            {
                Console.WriteLine("\n==============Withdraw from Accounts======================");
                foreach (var account in accounts)
                {
                    if (account.Withdraw(amount))
                        Console.WriteLine($"Withdraw {amount} to {account}");
                    else Console.WriteLine($"faild Withdraw of {amount} to {account}");
                }
            }
    }
}
