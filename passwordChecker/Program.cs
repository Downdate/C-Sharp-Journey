using System;

namespace passwordChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = string.Empty;
            string passwordConfirm = string.Empty;

            System.Console.Write("Please enter your password: ");
            password = Console.ReadLine();
            System.Console.WriteLine();

            if (!password.Equals(string.Empty))
            {
                System.Console.Write("Please enter your password again: ");
                passwordConfirm = Console.ReadLine();
                System.Console.WriteLine();

                if (!passwordConfirm.Equals(string.Empty))
                {
                    if (password.Equals(passwordConfirm))
                    {
                        System.Console.WriteLine("success!");
                    }
                    else
                    {
                        System.Console.WriteLine("password and confirmation don't match");
                    }
                    
                }
                else
                {
                    System.Console.WriteLine("confirmation is empty!");
                }

                
            }
            else
            {
                System.Console.WriteLine("no password recieved!");
            }

        }
    }

}