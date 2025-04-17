//Libraries
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public static void Numbers() //Main entry point for the program - c# is case sensitive
        {
            Console.WriteLine("Hello world"); //Instructions end with ;
            //Initializing and declaring in the same line
            int age = 33;
            Console.WriteLine(age);
            Console.WriteLine();

            //CSharp accepets on line declarations
            int numberOne = 885, numberTwo = 21, numberThree = 11;
            Console.WriteLine("{0},{1},{2}",numberOne,numberTwo,numberThree);
            //If we want to display multiple lines in a cw statetement we need to pass as first 
            //parameter a string, and the number in brackets are are variables to display

            Console.WriteLine(); //An empty cw will priny an empty line

            long bigNumber = 9000000000L; //L needed because int is a 32 bits signed numbers and 
                                          //long is a 64 bits signed we need to inform the compiler
                                          //by adding a L
            Console.WriteLine(bigNumber);
            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(long.MinValue);
            Console.WriteLine(long.MaxValue);
            Console.WriteLine();

            double negative = -27.5D; //same for negatives
            Console.WriteLine(negative);
            Console.WriteLine(double.MinValue);
            Console.WriteLine(double.MaxValue);
            Console.WriteLine();

            float smallDecimal = 0.84F; // same for floats
                                        //Float - decimal - double are all decimal numbers but 
                                        //float as smallest range and double largest
            Console.WriteLine(smallDecimal);
            Console.WriteLine(float.MinValue);
            Console.WriteLine(float.MaxValue);
            Console.WriteLine();

            decimal midDecimal = -0.885M;
            Console.WriteLine(midDecimal);
            Console.WriteLine(decimal.MinValue);
            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine();

            double bigDecimal = 0.774D;
            Console.WriteLine(bigDecimal);
            Console.WriteLine(double.MinValue);
            Console.WriteLine(double.MaxValue);
            Console.WriteLine();

            Console.ReadLine(); //Wait for enter input to close program 
        }
    }
}

namespace String_Chars
{
    using ConsoleApp1;
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Eve"; //quotations 
            char letter = 'e'; //only apostrophes
            Console.WriteLine("{0},{1}", name, letter);
            Console.WriteLine();
            string userInput = Console.ReadLine();
            if (userInput == "numbers")
            {
                ConsoleApp1.Program.Numbers();
            }
        }
    }
}