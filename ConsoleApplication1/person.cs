using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Person
    {
        string fname, lname, email;
        DateTime dob;

        public Person(string fname, string lname, string email, DateTime dob)
        {
            this.fname = fname;
            this.lname = lname;
            this.email = email;
            this.dob = dob;
        }
        public Person(string fname, string lname, string email)
        {
            this.fname = fname;
            this.lname = lname;
            this.email = email;
        }
        public Person(string fname, string lname, DateTime dob)
        {
            this.fname = fname;
            this.lname = lname;
            this.dob = dob;
        }
        public void Adult()
        {
            int age = DateTime.Now.Year - this.dob.Year;
            if (age > 18)
            {
                Console.WriteLine("You are 18 or Above. So you are an Adult");
            }
            else if (age == 18 && DateTime.Now.Month >= this.dob.Month)
            {
                if (DateTime.Now.Day >= this.dob.Day)
                    Console.WriteLine("You are 18 now. ADULT !!!");
                else if (DateTime.Now.Day < this.dob.Day)
                    Console.WriteLine("You are not 18 still. CHILD !!!");
            }
            else
                Console.WriteLine("You are below 18. So you are a Child");
        }
        public string SunSign()
        {
            string sign;
            int month = this.dob.Month;
            switch (month)
            {
                case 1:
                    sign = "Aquarius";
                    return sign;
                case 2:
                    sign = "Sagittarius";
                    return sign;
                case 3:
                    sign = "Leo";
                    return sign;
                case 4:
                    sign = "Pisces";
                    return sign;
                case 5:
                    sign = "Cancer";
                    return sign;
                case 6:
                    sign = "Aries";
                    return sign;
                case 7:
                    sign = "Gemini";
                    return sign;
                case 8:
                    sign = "Taurus";
                    return sign;
                case 9:
                    sign = "Virgo";
                    return sign;
                case 10:
                    sign = "Libra";
                    return sign;
                case 11:
                    sign = "Scorpio";
                    return sign;
                case 12:
                    sign = "Capricon";
                    return sign;
                default:
                    return null;

            }


        }
        public void Birthday()
        {
            if (DateTime.Now.Month == this.dob.Month && DateTime.Now.Day == this.dob.Day)
                Console.WriteLine("WISH YOU A HAPPY BIRTHDAY");
            else if (DateTime.Now.Month > this.dob.Month)
                Console.WriteLine("BELATED BIRTHDAY WISHES");
            else
                Console.WriteLine("ADVANCE HAPPY BIRTHDAY");
        }
        public void showData()
        {
            Console.WriteLine("\n\tPERSONAL DETAILS");
            Console.WriteLine("FIRST NAME :" + fname);
            Console.WriteLine("LAST NAME:" + lname);
            Console.WriteLine("EMAIL ID :" + email);
            Console.WriteLine("DATE OF BIRTH : " + dob);
        }
    }
}
