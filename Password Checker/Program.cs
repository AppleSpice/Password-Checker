using System;

namespace Password_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 1;
            int minLength = 8;
            string uppercase, lowercase, digits, specialChars;

            Console.WriteLine($"Hello there please enter your password. {score}");
            string password = Console.ReadLine(); 

            if (password.Length >= minLength)
            {
                score++;
            }
            

        }
    }
}
