using System;

namespace forLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("please enter a value: ");
            int loopCounter = Convert.ToInt32(Console.ReadLine());

            if (loopCounter <= 0){
                Console.WriteLine("Sorry, please enter a value above 0");
            }

            else{
                for (int i = 0; i < loopCounter; i++){
                System.Console.WriteLine("hello");
                }
            }
            
            /*for (int i = 0; i < loopCounter ; i +=2) {

                System.Console.WriteLine(i);

            }*/
            
        }
    }

}