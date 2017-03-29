using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09BankInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string FirstName;
            string MidName;
            string LastName;
            decimal Balance;
            string BankName;
            string IBAN;
            long CC1;
            long CC2;
            long CC3;

            FirstName = "Bill";
            MidName = "\"Bilkata\"";
            LastName = "Gatest";
            Balance = 1000000000000.34m;
            BankName = "DSK";
            IBAN = "BG007DSK123123123123";
            CC1 = 123123123123123;
            CC2 = 123123123234123;
            CC3 = 098098098098098;

            Console.WriteLine("Account: {0} {1} {2}\n\nBalance: {3}\n{4}\nIBAN: {5}\nCard Numbers:\n{6}\n{7}\n{8}", FirstName, MidName, LastName, Balance, BankName, IBAN, CC1, CC2, CC3);
        }
    }
}
