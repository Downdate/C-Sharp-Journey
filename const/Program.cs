using System;

namespace dataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            const int age = 23;
            Console.WriteLine(age);

            //can not change age constant

            //age = 24;

            const int vat = 20;
            const double percentVAT = vat / 100D;

            int balance = 1000;

            Console.WriteLine(balance*(percentVAT));

            const string version = "v1.0";

            Console.WriteLine(version);

            
        }
    }

}