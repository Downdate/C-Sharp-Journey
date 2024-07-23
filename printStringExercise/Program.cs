using System;

namespace printStringExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Enter your message: ");
            string message = Console.ReadLine();

            Random rnd = new Random();

            for (int i = 0; i < message.Length; i++)
            {
                Console.Write(message[i]);
                Thread.Sleep(rnd.Next(50,500));
            }
        }
    }

}