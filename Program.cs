using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBank
{ 
    public class Program
    {
        static void Main(string[] args)
        {
            //test 
            List<BankAccount> minibank = new List<BankAccount>();
            List<Transaction> minitransaction = new List<Transaction>();
            BankManager a = new BankManager();
            a.AddNewBankAccount(minibank);
            //a.AddNewBankAccount(minibank);
            //a.AddNewBankAccount(minibank);
            a.monthlyinterest(minitransaction, minibank, 0.01, 10);
            //foreach(var b in minitransaction)
            //{
            //    b.inlichsugiaodich();
            //    Console.WriteLine();
            //}

            //Console.WriteLine();
            //a.find_account_number(minibank);
            a.thongke(minibank);
        }
    }
}
