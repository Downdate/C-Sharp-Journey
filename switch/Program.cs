using System;

namespace switches
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("please enter a number between 1 and 7 : ");
            int day = Convert.ToInt32(Console.ReadLine());

            switch (day)
            {
                case 1: System.Console.WriteLine("Mon");
                    break;
                case 2: System.Console.WriteLine("Tue");
                    break;
                case 3: System.Console.WriteLine("Wed");
                    break ;
                case 4: System.Console.WriteLine("Thu");
                    break;
                case 5: System.Console.WriteLine("Fri");
                    break;
                case 6: System.Console.WriteLine("Sat");
                    break;
                case 7: System.Console.WriteLine("Sun");
                    break;
                default: System.Console.WriteLine("Invalid, please enter a number between 1 and 7 !");
                    break;
            }
            
        }
    }

}