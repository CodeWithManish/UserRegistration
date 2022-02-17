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
            string fname=Console.ReadLine();    

            if(reg.IsMatch(fname))
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
        }
    }
}
