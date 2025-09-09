using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniBank.Interfaces;

namespace MiniBank.AccountType
{
    public class SavingsAcount : BankAccount,IInterestBearing 
    {
        public double annual_interest_rate {get;protected set;}

        public SavingsAcount(string number_account, string own_name, double ballance, DateTime created_at,double annual_interest_rate) : base(number_account, own_name, ballance, created_at)
        {
            this.annual_interest_rate = annual_interest_rate;
        }
        public override void Deposit(double amount)
        {
            ballance += amount;
        }
        public void ApplyMonthlyInterest()
        {
            ballance += ballance * annual_interest_rate;
        }
    }
}
