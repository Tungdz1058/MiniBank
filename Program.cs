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
            a.Deposit(minitransaction,minibank);
            minitransaction[0].inlichsugiaodich();
            Console.WriteLine();
            a.find_account_number(minibank);
        }
    }
}
