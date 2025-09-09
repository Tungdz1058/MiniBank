using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
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
                Console.WriteLine("vui long nhap so tu 1 - 3 de thuc hien thao tac:");
                int val;
                while (true)
                {
                    
                    val = int.Parse(Console.ReadLine());
                    if (val > 0 && val < 4) break;
                }
                switch (val)
                {
                    case 1:
                    Nhaplai:
                        Console.Write("vui long nhap ID nguoi dung : ");
                        string ID1 = Console.ReadLine();
                        foreach (var a in minibank)
                        {
                            if (a.number_account == ID1)
                            {
                                Console.WriteLine("ID da co nguoi su dung vui long chon ID khac!!");
                                goto Nhaplai;
                            }
                        }
                        Console.Write("vui long nhap ten nguoi dung : ");
                        string name1 = Console.ReadLine();
                        Console.Write("vui long nhap so tien goc trong tai khoan (so tien phai >= 0): ");
                        double bal1 = double.Parse(Console.ReadLine());
                        Console.Write("vui long nhap ngay khoi tao MM/dd//yyyy : ");
                        DateTime date1 = DateTime.Parse(Console.ReadLine());
                        minibank.Add(new SavingsAcount(ID1, name1, bal1, date1, 0.01));
                        Console.WriteLine("Them tai khoan thanh cong!");
                        break;
                    case 2:
                    Nhaplai2:
                        Console.Write("vui long nhap ID nguoi dung : ");
                        string ID2 = Console.ReadLine();
                        foreach (var a in minibank)
                        {
                            if (a.number_account == ID2)
                            {
                                Console.WriteLine("ID da co nguoi su dung vui long chon ID khac!!");
                                goto Nhaplai2;
                            }
                        }
                        Console.Write("vui long nhap ten nguoi dung : ");
                        string name2 = Console.ReadLine();
                        Console.Write("vui long nhap so tien goc trong tai khoan (so tien phai >= 0): ");
                        double bal2 = double.Parse(Console.ReadLine());
                        Console.Write("vui long nhap ngay khoi tao MM/dd//yyyy : ");
                        DateTime date2 = DateTime.Parse(Console.ReadLine());
                        minibank.Add(new CheckingAccount(ID2, name2, bal2, date2, 10000));
                        Console.WriteLine("Them tai khoan thanh cong!");
                        break;
                    case 3:
                    Nhaplai3:
                        Console.Write("vui long nhap ID nguoi dung : ");
                        string ID3 = Console.ReadLine();
                        foreach (var a in minibank)
                        {
                            if (a.number_account == ID3)
                            {
                                Console.WriteLine("ID da co nguoi su dung vui long chon ID khac!!");
                                goto Nhaplai3;
                            }
                        }
                        Console.Write("vui long nhap ten nguoi dung : ");
                        string name3 = Console.ReadLine();
                        Console.Write("vui long nhap so tien goc trong tai khoan (so tien phai >= 0): ");
                        double bal3 = double.Parse(Console.ReadLine());
                        Console.Write("vui long nhap ngay khoi tao MM/dd//yyyy : ");
                        DateTime date3 = DateTime.Parse(Console.ReadLine());
                        minibank.Add(new CreditCard(ID3, name3, bal3, date3, 10000, 0.01));
                        Console.WriteLine("Them tai khoan thanh cong!");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("du lieu nhap vao khong dung vui long nhap lai!!");
                Console.WriteLine();
                goto NhapLai;
            }
        }



        // tim tai khoan bang account number

        public void find_account_number(List<BankAccount> minibank)
        {
            while (true)
            {
                Console.Write("nhap so tai khoan ban muon tim : ");
                string temp = Console.ReadLine();
                string numberaccount = "";
                foreach (var a in minibank)
                {
                    if (a.number_account == temp)
                    {
                        numberaccount = a.number_account;
                        Console.WriteLine("da tim thay tai khoan bat dau tien hanh in thong tin!!");
                        Console.WriteLine(a.ToString());
                        break;
                    }
                }
                if (numberaccount == "") Console.WriteLine("khong tim thay tai khoan vui long nhap lai so tai khoan!!");
                else break;
            }
        }

        //thuc hien deposit/withdraw -> ghi transaction
    }
}

