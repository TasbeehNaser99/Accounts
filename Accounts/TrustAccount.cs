using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounts
{
    internal class TrustAccount : SavingsAccount
    {    
        public static int Count { get; set; } 
        public double Bouns { get; }
        public TrustAccount(string name = "Unnamed Account", double balance = 0.0, double intrestRate = 0.01)
            :base(name, balance, intrestRate)
        {
            Bouns = 50.0;
            Count = 0;
        }
        public override bool Deposit(double amount) {
            if (amount >= 5000)
            {
              return  base.Deposit(amount + Bouns);
            }
           
               return base.Deposit(amount);
           
        }
        public override bool Withdraw(double amount)
        {
            if (Count < 3 && amount < .2 * GetBalance())
            {
                Count++;
                return base.Withdraw(amount);
            }
            else Console.WriteLine("Sorry, you have exceeded your withdrawal limit");
            return false;
        }
        public override string ToString()=> $"{base.ToString()} Bouns : {Bouns}";




    }
}
