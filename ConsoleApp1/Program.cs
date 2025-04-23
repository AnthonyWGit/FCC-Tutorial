//Libraries
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navigation
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringToDisplay = "Hello ! This is a console tool to show you the progress i did tracking the video" +
                "displayed in my readme file. Please type the chapter you want to select : \n 1 - String" +
                "\n 2 - Numbers \n 3 - Bool \n 4 - Operations \n 5 - Modulus \n 6 - Var \n" 
                +"Press the enter key to confirm. \n Type \"exit\" to exit the program";
            Console.WriteLine(stringToDisplay);
            string userInput = String.Empty;
            //if (userInput == "numbers")
            //{
            //    Numbers.Program.Numbers();
            //}
            //else if (userInput == "bool")
            //{
            //    Bool.Program.BoolExample();
            //}
            //else if (userInput == "operations")
            //{
            //    Operations.Program.Operations();
            //}
            //else
            //{
            //    Console.WriteLine("The program will exit.");
            //}
            while ( userInput != "exit")
            {
                userInput = Console.ReadLine();
                userInput = userInput.ToLower();
                switch (userInput)
                {
                    //in C# String are treated as objects so case "string" || "1": won't work
                    case string placeholder when placeholder == "string" || placeholder == "1":
                        StringChars.Program.StringLetters();
                        userInput = "";
                        break;
                    case string placeholder when placeholder == "numbers" || placeholder == "2":
                        Numbers.Program.Numbers();
                        userInput = "";
                        break;
                    case string placeholder when placeholder == "bool" || placeholder == "3":
                        Bool.Program.BoolExample();
                        userInput = "";
                        break;
                    case string placeholder when placeholder == "operations" || placeholder == "4":
                        Operations.Program.Operations();
                        userInput = "";
                        break;
                    case string placeholder when placeholder == "modulus" || placeholder == "5":
                        Modulus.Program.Modulus();
                        userInput = "";
                        break;
                    case string placeholder when placeholder == "var" || placeholder == "6":
                        Var.Program.Var();
                        userInput = "";
                        break;
                    case "exit":
                        return; //return the main method so it means the program is closing correctly
                    default:
                        break;
                }
            }
        }
}
namespace Numbers
{
    internal class Program
    {
        public static void Numbers() //Main entry point for the program - c# is case sensitive
            //Here it is a public function so it can be accessed from anywhere else in the program
        {
            Console.WriteLine("Hello world"); //Instructions end with ;
            //Initializing and declaring in the same line
            int age = 33;
            Console.WriteLine(age);
            Console.WriteLine();

            //Whole numbers ---
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

            double negative = -27L; //same for negatives
            Console.WriteLine(negative);
            Console.WriteLine(double.MinValue);
            Console.WriteLine(double.MaxValue);
            Console.WriteLine();

            //Decimals --- 

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

            //Console.ReadLine(); //Wait for enter input to close program 
        }
    }
}

namespace StringChars
{
    internal class Program
    {
        public static void StringLetters()
        {
            string name = "Eve"; //quotations 
            char letter = 'e'; //only apostrophes
            //Conversions
            string ageString = "15";
            int ageConverted = Convert.ToInt32(ageString);

            string doubleString = "-800000000";
            double doubleConverted = Convert.ToDouble(doubleString);

            string floatString = "9,0004"; //comma instad of point because my system locale is FR
                                           //if locale is US use point
            float floatConverted = Convert.ToSingle(floatString);

            Console.WriteLine("{0},{1}", name, letter);
            Console.WriteLine("This is a \n carriage return");

            Console.WriteLine("Using conversion functions");
            Console.WriteLine(ageConverted);
            Console.WriteLine(doubleConverted);
            Console.WriteLine(floatConverted);
            }
        }
    }
}

namespace Bool
{
    class Program
    {
        public static void BoolExample()
        {
            bool value = true;

            bool isFemale = true;
            Console.WriteLine("{0},{1}", value, isFemale);
            isFemale = false;
            Console.WriteLine("{0},{1}", value, isFemale);
        }
    }
}

namespace Operations
{
    class Program
    {
        public static void Operations()
        {
            int age = 15; //this is a local variable so that's why we can use age multiple times
            //incrementations
            Console.WriteLine("{0} {1} {2} {3} {4}", "Age datatype : ",age.GetType(),"and", "Age = ", age);
            age++;
            //Same as
            age += 1;
            age = age + 5;
            //same as 
            age += 5;
            Console.WriteLine("{0} {1}", "Age = ", age);
            age--;
            Console.WriteLine("{0} {1}", "Age = ", age);
            //If any division make it a double
            double trueAge = (double) age;
            //GetType gets the datatype of var at runtime
            Console.WriteLine("{0}, {1} {2}", trueAge.GetType(),"True age is :",trueAge);
            trueAge /= 7.5;
            //same as trueAge = trueAge / 7.5
            Console.WriteLine(trueAge);

            //string addition
            string stringOperation = "The quick brown fox ";
            stringOperation += "jumps over the lazy dog";
            //C# is not build for string removal; stringOperation -= "dog" is a no go 
            Console.WriteLine(stringOperation);

            char letter = 'a';
            letter += 'c';
            Console.WriteLine(letter);

            int k = 5;
            Console.WriteLine("{0} {1}","++k :",++k); //This instruction does the incrementation first
                                                       //Then use the return value
            k = 5;
            Console.WriteLine("{0} {1}","k++ :", k++);//It returns k first then does the increment
        }
    }
}

namespace Modulus
{
    class Program
    {
        public static void Modulus()
        {
            int number1 = 25;
            int number2 = 4;
            Console.WriteLine(number1 % number2); //outputs 1 - Modulus very usefull to determine if 
            //odd number or not when using  %2
        }
    }
}

namespace Var
{
    class Program
    {
        public static void Var()
        {
            Console.WriteLine("var is a keyword wich tells the compiler to auto assign the datatype of"
                + " the variable based on its assigned value");
            var age = 266;
            Console.WriteLine(age + " ans");
        }
    }
}