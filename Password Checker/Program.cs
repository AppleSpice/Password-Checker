using System;

namespace Password_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 0;
            int minLength = 8;
            string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowercase = "abcdefghijklmnopqrstuvwxyz";
            string digits = "1234567890";
            string specialChars = "?!$%&";

            Console.WriteLine($"Hello there please enter your password.");
            string password = Console.ReadLine(); 

            //password length
            if (password.Length >= minLength)
            {
                score++;
            }
            //password uppercase
            if (Tools.Contains(password, uppercase))
            {
                score++;
            }
            //password lowercase
            if (Tools.Contains(password, lowercase))
            {
                score++;
            }
            //password digits
            if (Tools.Contains(password, digits))
            {
                score++;
            }
            //password special chars
            if (Tools.Contains(password, specialChars))
            {
                score++;
            }

            switch (score)
            {
                case 1:
                    {
                        Console.WriteLine("Uh oh Your password is really weak.");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Your password is around medium strength.");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("You have a strong password.");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("You have an extremely strong password!");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("You have an extremely strong password!");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("That doesn't meet any password standards!");
                        break;
                    }

            }

                


        }
    }
}
