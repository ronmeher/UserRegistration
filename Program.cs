using System;
using System.Text.RegularExpressions;



namespace UserRegistration
{



    internal class Program
    {

        public static string FIRSTNAME = "^[A-Z][a-z]*$";
        
        public bool validateFirstName()
        {
            Console.WriteLine("Enter your First Name");
            string firstname = Console.ReadLine();
            return Regex.IsMatch(firstname, FIRSTNAME);
        }

        






        static void Main(string[] args)
        {
            Console.WriteLine("USER REGISTRATION PROGRAM!\n");

            Program p = new Program();
            Console.WriteLine(p.validateFirstName());
        
        }
    }
}
