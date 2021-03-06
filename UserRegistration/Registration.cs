using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class Registration
    {
        public void UserData()
        {
            Regex reg = new Regex("^[A-Z]{1}[a-z]{3,12}$");

            Console.WriteLine("Enter FirstName");
            string fname = Console.ReadLine();

            if (reg.IsMatch(fname))
            {
                Console.WriteLine("Your Name is: " + fname);
            }
            else
            {
                Console.WriteLine("Please Enter valid Name!");
            }

            //UseCase 2

            Regex reg1 = new Regex("^[A-Z]{1}[a-z]{3,12}$");

            Console.WriteLine("Enter LastName");
            string lname = Console.ReadLine();

            if (reg1.IsMatch(lname))
            {
                Console.WriteLine("Your Name is: " + lname);
            }
            else
            {
                Console.WriteLine("Please Enter valid Name!");
            }

            //

            string regex1 = "^[a-zA-Z0-9]{3,}[.][a-zA-Z0-9]{3,}[@][a-zA-Z0-9]{2,}[.][a-zA-Z]{2,}[.][a-zA-Z]{2}?$";
            string regex2 = "^[A-Za-z0-9]{3,}[@][A-za-z]{3,}[.][A-Za-z]{3}$";

            Regex exp1 = new Regex(regex1);
            Regex exp2 = new Regex(regex2);

            Console.WriteLine("Enter Email id");
            string email = Console.ReadLine();
            if (exp1.IsMatch(email) || exp2.IsMatch(email))
            {
                Console.WriteLine("your Email id is :" + email);

            }
            else
            {
                Console.WriteLine("Enter valid Email id!");
            }

            //

            Regex regex3 = new Regex("^[+][0-9]{2}[ ][6-9]{1}[0-9]{9}$");
            Console.WriteLine("Enter Contact Number :");
            string phoneNumber = (Console.ReadLine());

            if (regex3.IsMatch(phoneNumber))
            {
                Console.WriteLine("your contact number is :" + phoneNumber);
            }
            else
            {
                Console.WriteLine("Enter valid Mobile Number!");
            }

            //


            Regex regex4 = new Regex("^[a-zA-Z0-9]{8,}$");
            Console.WriteLine("Enter password minimum 8 characters");
            string password = Console.ReadLine();

            if (regex4.IsMatch(password))
            {
                Console.WriteLine("Your password is :" + password);
            }
            else
            {
                Console.WriteLine("Enter valid Password");
            }

            //
            
            Regex pattern = new Regex("^(?=.*[A-Z]).{8,}$");
            Console.WriteLine("Enter password minimum 8 characters with one upper case");
            string pwd = Console.ReadLine();
            if (pattern.IsMatch(pwd))
            {
                Console.WriteLine("Your password is :" + pwd);
            }
            else
            {
                Console.WriteLine("Enter valid Password");


            }

            //
            Regex pttrn = new Regex("^(?=.*[a-zA-Z])(?=.*[0-9]).+$");
            Console.WriteLine("Enter password atleast one Numeric Number");
            string pass = Console.ReadLine();
            if (pttrn.IsMatch(pass))
            {
                Console.WriteLine("Your password is :" + pass);
            }
            else
            {
                Console.WriteLine("Enter valid Password");

            }

            //

            Regex pttrn1 = new Regex("^(?=[a-zA-Z0-9#@$?]{8,}$)(?=.*?[a-z])(?=.*?[A-Z])(?=.*?[0-9]).*");
            Console.WriteLine("Enter password ");
            string pass1 = Console.ReadLine();
            if (pttrn1.IsMatch(pass1))
            {
                Console.WriteLine("Your password is :" + pass1);
            }
            else
            {
                Console.WriteLine("Enter valid Password");

            }

            //

        }
    }
}
