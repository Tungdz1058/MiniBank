using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBank
{
    public class Transaction
    {
        public string Id { get; }
        public string AccountNumber { get; }
        public string Type { get; } // "Deposit", "Withdraw", "Fee", "Interest"
        public double Amount { get; }
        public DateTime Timestamp { get; }
        public string Note { get; }

        public Transaction(string id,string numberaccount,string type,double amount,DateTime timestamp,string note)
        {
            this.Id = id;
            this.AccountNumber = numberaccount;
            this.Type = type;
            this.Timestamp = timestamp;
            this.Amount = amount;
            this.Note = note;
        }

        public void inlichsugiaodich()
        {
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Number Account: {AccountNumber}");
            Console.WriteLine($"Type : {Type}");
            Console.WriteLine($"Amount : {Amount}");
            Console.WriteLine($"Time Stamp: {Timestamp}");
            Console.WriteLine($"Note : {Note}");
        }
    }
}
