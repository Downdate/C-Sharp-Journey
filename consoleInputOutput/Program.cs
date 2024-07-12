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

            System.Console.WriteLine($"your name is {name}");
        }
    }

}