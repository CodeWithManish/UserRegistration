﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration.!\n");
            /*Registration registration = new Registration();
            registration.UserData();*/

            RegexSample regexSample = new RegexSample();
            regexSample.Validating();
            Console.ReadKey();

        }
    }
}
