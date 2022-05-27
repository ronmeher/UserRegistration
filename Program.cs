using System;
using System.Text.RegularExpressions;



namespace UserRegistration
{



    internal class Program
    {

        public static string FIRSTNAME = "^[A-Z][a-z]*$";
        public static string LASTNAME = "^[A-Z][a-z]*$";
        public static string EMAIL = @"^[\w \- . ]{1,}@?[a-z A-Z]{2,}.?(com)$";
        public static string PHONE = "^[9][1][6-9][0-9]{9}$";
        public static string PASSWORD = "^[a-z A-Z]{8}[a-z A-Z]*$";

        public bool validateFirstName()
        {
            Console.WriteLine("\nEnter your First Name");
            string firstname = Console.ReadLine();
            return Regex.IsMatch(firstname, FIRSTNAME);
        }

        public bool validateLastName()
        {
            Console.WriteLine("\nEnter your Last Name!");
            string lastname = Console.ReadLine();
            return Regex.IsMatch(lastname, LASTNAME);
        }

        public bool validateEmail()
        {
            Console.WriteLine("\nEnter your Email ID!");
            string email = Console.ReadLine();
            return Regex.IsMatch(email, EMAIL);
        }

        

        public bool validatePhone()
        {
            Console.WriteLine("\nEnter your Phone Number!");
            string phone = Console.ReadLine();
            return Regex.IsMatch(phone, PHONE);
        }

        public bool validatePassword()
        {
            Console.WriteLine("\nEnter your Password!");
            string password = Console.ReadLine();
            return Regex.IsMatch(password, PASSWORD);
        }


        static void Main(string[] args)
        {
            Console.WriteLine("USER REGISTRATION PROGRAM!\n");

            Program p = new Program();
            Console.WriteLine(p.validateFirstName());
            Console.WriteLine(p.validateLastName());
            Console.WriteLine(p.validateEmail());
            Console.WriteLine(p.validatePhone());
            Console.WriteLine(p.validatePassword());
        }
    }
}
