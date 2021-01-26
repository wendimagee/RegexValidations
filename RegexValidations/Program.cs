﻿using System;
using System.Text.RegularExpressions;


namespace RegexValidations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name, phone number, email address or a date");
            string input = Console.ReadLine();

            Console.WriteLine(NameValidation(input));
            Console.WriteLine(EmailValidation(input));
            Console.WriteLine(PhoneValidation(input));
            Console.WriteLine(DateValidation(input));

        }

        public static bool NameValidation(string input)
        {
            Regex name = new Regex(@"\b([A-ZÀ-ÿ][-,a-z. ']+[ ]*)+");

            if (name.IsMatch(input))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool EmailValidation(string input)
        {
            Regex email = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

            if (email.IsMatch(input))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public static bool PhoneValidation(string input)
        {
            Regex phone = new Regex(@"\d\d\d-\d\d\d-\d\d\d\d");

            if (phone.IsMatch(input))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool DateValidation(string input)
        {
            Regex date = new Regex(@"\d\d/\d\d/\d\d\d\d");

            if (date.IsMatch(input))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}