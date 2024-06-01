using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousApp
{
    public class Account
    {
        public double Balance { get; set; }
        public Account(double bal) {
            this.Balance = bal;
        }   
        public void Withdraw(double amt) {
            Balance -=  amt;    
        }
        public void Deposit(double amt)
        {
            Balance += amt;
        }
    }
}
