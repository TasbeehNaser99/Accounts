using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Accounts
{
    internal class Account
    {
        private string name;
        private double balance;

        public Account(string name = "Unnamed Account", double balance = 0.0) {
            this.name =name;
           this.balance = balance;
        }



        public virtual bool Deposit(double amount) {
            if (amount < 0)
                return false;

            else
            {
                balance += amount;
                return true;
            }
            
        }
        public virtual bool Withdraw(double amount)
        {
            if (balance - amount >= 0)
            {
                balance -= amount;
                return true;
            }
            else
                return false;
        }

        public static double operator +(Account a ,Account b)=>a.balance + b.balance;
        
        public double GetBalance() => balance;
        public override string ToString() => $"[Account: {name}: {balance}]";



    }
}
