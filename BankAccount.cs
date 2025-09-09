using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniBank.Exception;

namespace MiniBank
{
    public class BankAccount 
    {
        public string number_account { get; set; }
        public string own_name { get; set; }
        public double ballance {get; protected set;}
        private double ball
        {
            get { return ballance; }
            set
            {
                if (value < 0) ballance = 0;
                else ballance = value;
            }
        }
        public DateTime created_at { get; set; }

        protected BankAccount(string number_account, string own_name, double ballance, DateTime created_at)
        {
            this.number_account = number_account;
            this.own_name = own_name;
            try
            {
                this.ball = ballance;
                if (ballance < 0) throw new NegativeAmountException("tai khoan khoi tao phai co so tien >=0 he thong tu dat so tien goc = 0!!!");
            }
            catch (NegativeAmountException ex)
            {
                Console.WriteLine("loi : {0}",ex);
                Console.WriteLine();
            }
            this.created_at = created_at;
        }
        public virtual void Deposit(double amount) { } //nap tien
        public virtual void Withdraw(double amount) { } //rut tien
        public override string ToString() //thong tin tai khoan
        {
            return $"{number_account} - {own_name} : {ballance}";
        }
    }
}
