using System;

namespace PracticewithVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 17; //numerical value
            bool conditional = true; // true or false value
            char letter = 'S'; //single value
            string firstName = "William"; //combination of values
            //can't change data type. every variable must be set to a data type
            double num = 5.8; //decimals
            decimal X = 178.22M; //decimals
            Console.WriteLine($"My name is {firstName} {letter} I am {number} years old") ;
     
            Console.WriteLine($"I am {num} inches or {X} cm and all of this is {conditional}");
        }
    }
}
