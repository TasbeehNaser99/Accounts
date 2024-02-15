using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounts
{
    internal class CheckingAccount : Account
    { 
        public double Fee {  get; set; }
        public CheckingAccount(string name = "Unnamed Account", double balance = 0.0)
             : base(name, balance)
        { 
            Fee = 1.5;
        }
        public override bool Withdraw(double amount)
        {
            return base.Withdraw(amount + Fee);

        }
        public override string ToString()=> $"{base.ToString()} Fee : {Fee} ";



    }
}
