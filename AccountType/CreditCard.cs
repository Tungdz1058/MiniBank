using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniBank.Exception;
using MiniBank.Interfaces;

namespace MiniBank.AccountType
{
    public class CreditCard : BankAccount,IInterestBearing,FeeDeductible 
    {
        private double creditlimit = -2000000.0;
        private double fee { get; set; }
        private double interest { get; set; }

        public CreditCard(string number_account, string own_name, double ballance, DateTime created_at,double fee,double interest) : base(number_account, own_name, ballance, created_at)
        {
            this.fee = fee;
            this.interest = interest;
        }

        public void ApplyMonthlyFee()
        {
            ballance -= fee;
        }

        public void ApplyMonthlyInterest()
        {
            if (ballance < 0)
            {
                ballance -= Math.Abs(ballance) * interest;
            }
        }
        public override void Deposit(double amount)
        {
            ballance += amount;
        }
        public override void Withdraw(double amount)
        {
            try
            {
                if (ballance - amount > creditlimit)
                {
                    ballance -= amount;
                    Console.WriteLine($"rut thanh cong {amount} so du con lai trong tai khoan la {ballance}");
                }
                else throw new OverdraftLimitExceededException("so tien rut da vuot qua gioi han cho phep vui long giam so tien rut!!!");
            }
            catch(OverdraftLimitExceededException ex)
            {
                Console.WriteLine("loi : {0}", ex);
            }
        }
    }
}
