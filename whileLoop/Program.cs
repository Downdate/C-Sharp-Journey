using System;
using System.Runtime.Intrinsics.Arm;

namespace whileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            /*for (int i = 0; i < 10; i++){
                Console.WriteLine(i);
            }*/
            //int i = 0; 

            /*while (i < 10)
            {
                System.Console.WriteLine(i);
                i++;
            }*/

            /*while (true)
            {
                System.Console.WriteLine("Hello");
            }*/

            Console.Write("please enter the first number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("please enter the second number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            int answer = firstNumber * secondNumber;
            int actualAnswer = 0;

            Console.Write($"What's the value of {firstNumber} X {secondNumber} ?");
            Console.WriteLine();

            do
            {
                Console.Write("Enter your answer: ");
                int answerInput = Convert.ToInt32(Console.ReadLine());
                actualAnswer = answerInput;
                System.Console.WriteLine();

                if (answerInput != answer){
                    Console.WriteLine("Close but it was wrong!");
                    Console.WriteLine();
                }



            } while (answer != actualAnswer);

            Console.WriteLine("well done!");

            
        }
    }

}