using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounts
{
    internal class SavingsAccount: Account
    {
        public double IntrestRate { get; set; }
        public SavingsAccount(string name = "Unnamed Account", double balance = 0.0, double intrestRate=0.01)
            : base(name,balance)
        { 
        IntrestRate=intrestRate;
        }

        public override bool Withdraw(double amount) => base.Withdraw(amount + IntrestRate);

        public override string ToString() => $"{base.ToString()} , {IntrestRate}";

    }
}
