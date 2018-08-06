using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Accounts
    {
        int acc_no;
        string acc_name, acc_type;

        double amount;
        static double bal;

        public Accounts(int num, string name, string type)
        {
            acc_no = num;
            acc_name = name;
            acc_type = type;
            bal = 1000;
        }

        public void credit(double amount)
        {

            this.amount = amount;
            bal = bal + amount;
        }
        public void debit(double amt)
        {

            amount = amt;
            bal = bal - amount;

        }
        public void showData()
        {
            Console.WriteLine("ACCOUNT NO. :" + acc_no);
            Console.WriteLine("ACCOUNT NAME :" + acc_name);
            Console.WriteLine("ACCOUNT TYPE :" + acc_type);
            Console.WriteLine("BALANCE AMOUNT :" + bal);
        }
    }
}
