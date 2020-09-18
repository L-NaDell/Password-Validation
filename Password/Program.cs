using System;

namespace Password
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a password into the console.");

            string password = Console.ReadLine();

            if (password.Length >= 7 && 
                password.Length <= 12 &&
                password.Contains ('!') && 
                UpperCaseLetter(password) &&
                LowerCaseLetter(password))
            {
                Console.WriteLine("Password valid and accepted");
            }
            else 
            { 
                Console.WriteLine("Error"); 
            }
        }

        public static bool LowerCaseLetter(string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsLower(password[i]))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool UpperCaseLetter(string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsUpper(password[i]))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
