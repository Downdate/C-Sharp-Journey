using System;
using System.Runtime.Intrinsics.Arm;

namespace dataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello my name is Daniel!");
            // no new lines 
            System.Console.Write("please enter your name : ");

            string  name;
            // getting the name
            name = Console.ReadLine();
            System.Console.WriteLine();
            System.Console.WriteLine($"your name is {name}");

            Console.Write("please enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("");
            System.Console.WriteLine($"your age is {age}");

            if (age < 18){
                System.Console.WriteLine("");
                System.Console.WriteLine("sorry you can't enter the site!");
            }
            else{
                System.Console.WriteLine("");
                System.Console.WriteLine("welcome to the site!");
                
            }

        }
    }

}