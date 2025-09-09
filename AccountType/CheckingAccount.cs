using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniBank.Exception;
using MiniBank.Interfaces;

namespace MiniBank.AccountType
{
    public class CheckingAccount : BankAccount, FeeDeductible 
    {
        public double fee { get; protected set; }
        public CheckingAccount(string number_account, string own_name, double ballance, DateTime created_at,double fee) : base(number_account, own_name, ballance, created_at)
        {
            this.fee = fee;
        }

        public void ApplyMonthlyFee()
        {
            ballance -= fee;
        }
        public override void Deposit(double amount)
        {
            ballance += amount;
        }
        public override void Withdraw(double amount)
        {
            try
            {
                if (ballance - amount - fee > 0)
                {
                    ballance -= (amount + fee);
                    Console.WriteLine($"rut thanh cong {amount} so du con lai trong tai khoan la {ballance}");
                }
                else throw new OverdraftLimitExceededException("so tien rut da vuot qua gioi han cho phep vui long giam so tien rut!!!");
            }
            catch (OverdraftLimitExceededException ex)
            {
                Console.WriteLine("loi : {0}", ex);
            }
        }
    }
}
