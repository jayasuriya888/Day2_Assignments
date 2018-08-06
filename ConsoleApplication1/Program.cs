using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch;

            Console.WriteLine("Enter your Transaction type(D -->Deposit, W -->Withdrawal");
            char tr = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Transaction Amount");
            double amt = double.Parse(Console.ReadLine());
            Accounts acc = new Accounts(154634, "aaa", "RD");

            if (tr == 'D')
            {
                acc.credit(amt);
            }
            if (tr == 'W')
            {
                acc.debit(amt);
                Console.WriteLine("Thank you for Banking");
            }
            acc.showData();
            Console.WriteLine("\n\n\n");



            Shapes s = new Shapes();
            s.area(2); s.showData();
            s.area(3, 3); s.showData();
            s.area(4, 4, 0.5); s.showData();
            s.area(3.14, 5); s.showData();

            Console.WriteLine("Enter the dob");
            DateTime dob = DateTime.Parse(Console.ReadLine());

            Person p = new Person("aaa", "zzz", "aaa@hmail.com", dob);
            p.Adult();
            Console.WriteLine("Your Sun Sign is " + p.SunSign());
            p.Birthday();
            p.showData();

            Console.WriteLine("Enter the dob");
            dob = DateTime.Parse(Console.ReadLine());
            Person p1 = new Person("bbb", "yyy", dob);
            p1.Adult();
            Console.WriteLine("Your Sun Sign is " + p1.SunSign());
            p1.Birthday();
            p1.showData();

            Person p2 = new Person("ccc", "yyy", "ccc@gmail.com");
            p2.showData();

        }
    }
}
