using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace UserRegex

{
    class Program

    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Program");
            string fname, lname, email, phoneNo, password;
            string name_pattern, email_pattern, phone_pattern, password_pattern;
            while (true)
            {
                Console.WriteLine("Enter your first name with first letter in capitals ");
                fname = Console.ReadLine();
                List<string> list = new List<string>();
                list.Add(fname);
                name_pattern = @"^[A-Z]{1}[a-z]{2,}";
                Regex regex = new Regex(name_pattern);
                var result1 = list.TrueForAll(fname => regex.Match(fname).Success);
                if (result1)
                {
                    Console.WriteLine("Valid First Name");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid First Name");
                }
            }
            while (true)
            {
                Console.WriteLine("Enter your last name(only first letter in CAPS): ");
                lname = Console.ReadLine();
                List<string> list = new List<string>();
                list.Add(lname);
                name_pattern = @"^[A-Z]{1}[a-z]{2,}";
                Regex regex = new Regex(name_pattern);
                bool result1 = list.TrueForAll(lname => regex.Match(lname).Success);
                if (result1)
                {
                    Console.WriteLine("Valid Last Name");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Last Name");
                }
            }
            Console.WriteLine("Your Entered Name is " + fname + " " + lname);
            while (true)
            {
                Console.WriteLine("Enter your Email-id: ");
                email = Console.ReadLine();
                List<string> list = new List<string>();
                list.Add(email);

                email_pattern = @"^[A-Za-z]+[\w.+-]*[@][A-Za-z0-9]+[.][a-z]{2,}[.]?[a-z]*$";
                Regex regex = new Regex(email_pattern);
                bool result = list.TrueForAll(email => regex.Match(email).Success);
                    if (result)
                    {
                    Console.WriteLine("Valid Email-Id: " + email);
                    break;
                    }
                    else
                    {
                    Console.WriteLine("Invalid Email-Id");
                    }              
                break;
            }
            while (true)
            {
                Console.WriteLine("Enter the Valid Phone Number: ");
                phoneNo = Console.ReadLine();
                List<string> list = new List<string>();
                list.Add(phoneNo);
                phone_pattern = @"^[0-9]{2}[ ][0-9]{10}$";
                Regex regex = new Regex(phone_pattern);
                bool result = list.TrueForAll(phoneNo => regex.Match(phoneNo).Success);
                if (result)
                {
                    Console.WriteLine("Valid Phone Number: " + phoneNo);
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Phone Number");
                }
            }
            while (true)
            {
                Console.WriteLine("Set a password: ");
                password = Console.ReadLine();
                List<string> list = new List<string>();
                list.Add(password);
                password_pattern = @"(?=.*[A-Z])(?=.*\w)(?=.*\d)(?=[^@$!%*^#?&]*[@$!%*^#?&][^@$!%^*#?&]*$).{8,}$";
                Regex regex = new Regex(password_pattern);
                bool result = list.TrueForAll(password => regex.Match(password).Success);
                if (result)
                {
                    Console.WriteLine("Password set Successfully");
                    break;
                }
                else
                {
                    Console.WriteLine("Enter password again");
                }
            }
        }

    }
}
