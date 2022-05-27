using System;
using System.Text.RegularExpressions;



namespace UserRegistration
{



    internal class Program
    {

        public static string FIRSTNAME = "^[A-Z][a-z]*$";
        public static string LASTNAME = "^[A-Z][a-z]*$";


        public bool validateFirstName()
        {
            Console.WriteLine("Enter your First Name");
            string firstname = Console.ReadLine();
            return Regex.IsMatch(firstname, FIRSTNAME);
        }

        public bool validateLastName()
        {
            Console.WriteLine("Enter your Last Name");
            string lastname = Console.ReadLine();
            return Regex.IsMatch(lastname, LASTNAME);
        }






        static void Main(string[] args)
        {
            Console.WriteLine("USER REGISTRATION PROGRAM!\n");

            Program p = new Program();
            Console.WriteLine(p.validateFirstName());
            Console.WriteLine(p.validateLastName());

        }
    }
}
