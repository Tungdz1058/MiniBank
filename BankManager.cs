using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniBank.AccountType;

namespace MiniBank
{
    public class BankManager
    {

        //method them BankAccount tuy theo loai

        public void AddNewBankAccount(List<BankAccount> minibank)
        {
            NhapLai:
            try
            {
                Console.WriteLine("ban muon chon loai tai khoan nao?");
                Console.WriteLine("1. Saving Account (Tai khoan tiet kiem).");
                Console.WriteLine("2. Checking Account (Tai khoan thanh toan).");
                Console.WriteLine("3. Credit Account (Tai khoan the ghi no).");
                int val = int.Parse(Console.ReadLine());
                switch (val)
                {
                    case 1:
                        Nhaplai:
                        Console.WriteLine("vui long nhap ID nguoi dung : ");
                        string ID = Console.ReadLine();
                        foreach(var a in minibank)
                        {
                            if(a.number_account == ID)
                            {
                                Console.WriteLine("ID da co nguoi su dung vui long chon ID khac!!");
                                goto Nhaplai;
                            }
                        }
                        Console.WriteLine("vui long nhap ten nguoi dung : ");
                        string name = Console.ReadLine();
                        Console.WriteLine("vui long nhap so tien goc trong tai khoan (so tien phai >= 0)!");
                        double bal = double.Parse(Console.ReadLine());
                        Console.WriteLine("vui long nhap ngay khoi tao : ");
                        DateTime date = DateTime.Parse(Console.ReadLine());
                        minibank.Add(new SavingsAcount(ID, name, bal, date,0.01));
                        Console.WriteLine("Them tai khoan thanh cong!");
                    break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("du lieu nhap vao khong dung vui long nhap lai!!");
                goto NhapLai;
            }
        }

    }
}
