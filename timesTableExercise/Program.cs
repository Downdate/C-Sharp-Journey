using System;
using System.Runtime.Intrinsics.Arm;

namespace tryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            * Ask the user for a number for the table
            * Write a for loop to print X times table
            */
            bool success = true;

            while (success)
            {
                    System.Console.Write("Enter a number for the table: ");
                string userInput = Console.ReadLine();
                if (int.TryParse(userInput, out int result)){
                        success = false;
                        int userNumber = Convert.ToInt32(userInput);
                        for (int i = 1; i <= userNumber; i++)
                        {
                            for (int j = 1; j <= userNumber; j++)
                            {
                                System.Console.Write($" {i*j} ");
                            }
                            System.Console.WriteLine();
                        }
                }
                else{
                    System.Console.WriteLine("Invalid input!");
                }
            }

            
        }
    }

}