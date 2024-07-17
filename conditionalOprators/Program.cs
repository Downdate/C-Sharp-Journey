using System;

namespace conditionalOprators
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 10;

            string result = age >= 0 ? "Valid" : "Invalid";
            System.Console.WriteLine(result);
            
        }
    }

}