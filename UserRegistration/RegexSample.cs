using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
     class RegexSample
    {
      //  string pattern = "^[A-Za-z]{2,}$";
        public void Validating()
        {

           // Regex regexp = new Regex(pattern);
            Console.WriteLine("Validating The Email Id");
            Console.WriteLine("Enter Email Id");
            string input1 = Console.ReadLine();
            ValidatingEmailId(input1);
            Console.WriteLine("Validating The Email Id");
            Console.WriteLine("Enter Email Id");
            string input2 = Console.ReadLine();
            ValidatingEmailId(input2);
            Console.WriteLine("Validating The Email Id");
            Console.WriteLine("Enter Email Id");
            string input3 = Console.ReadLine();
            ValidatingEmailId(input3);
            Console.WriteLine("Validating The Email Id");
            Console.WriteLine("Enter Email Id");
            string input4 = Console.ReadLine();
            ValidatingEmailId(input4);
            Console.WriteLine("Validating The Email Id");
            Console.WriteLine("Enter Email Id");
            string input5 = Console.ReadLine();
            ValidatingEmailId(input5);
            Console.WriteLine("Validating The Email Id");
            Console.WriteLine("Enter Email Id");
            string input6 = Console.ReadLine();
            ValidatingEmailId(input6);
            Console.WriteLine("Validating The Email Id");
            Console.WriteLine("Enter Email Id");
            string input7 = Console.ReadLine();
            ValidatingEmailId(input7);
            Console.WriteLine("Validating The Email Id");
            Console.WriteLine("Enter Email Id");
            string input8 = Console.ReadLine();
            ValidatingEmailId(input8);
            Console.WriteLine("Validating The Email Id");
            Console.WriteLine("Enter Email Id");
            string input9 = Console.ReadLine();
            ValidatingEmailId(input9);
        }
        public static string ValidatingEmailId(string email)
        {
                      //^[A-Z0-9a-z]{1,}([.#$^_-][A-Za-z0-9]+)?[@][A-Za-z]{2,}[.][A-Za-z]{2,3}([.][a-zA-Z]{2,3})?$

            Regex regexp = new Regex("^[a-zA-Z0-9]{1,}([_.+-][a-zA-Z0-9]+)?[@][a-zA-Z0-9]{2,}[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3})?$");

            bool result = regexp.IsMatch(email);
            if (result)
            {
                Console.WriteLine("Email id is valid\n");
                return email;
            }
            else
            {
                Console.WriteLine("Email id is Invalid\n");
            }

            return default;
        }
    }
}
