﻿//Libraries
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Channels;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Navigation
{
    class Program
    {
        static void Main(string[] args) //Main entry point for the program - c# is case sensitive
        {
            string stringToDisplay = "Hello ! This is a console tool to show you the progress i did tracking the video" +
                "displayed in my readme file. Please type the chapter you want to select : \n 1 - String" +
                "\n 2 - Numbers \n 3 - Bool \n 4 - Operations \n 5 - Modulus \n 6 - Var \n 7 - Const \n" 
                + " 8 - dataTypes \n 9 - UserName \n 10 - Guess the number \n 11 - For loop \n" + 
                " 12 - While loop \n 13 - Conditional/Ternary Operator \n 14 - Format Pattern \n"
                + " 15 - FizzBuzz \n 16 - Verbatim \n 17 - StringFormat \n 18 - Interpolation \n 19 - StringConcat \n "
                + "20 - Equals \n 21 - LoopIteration \n 22 - EmptyOrNull \n 23 - LoopReverse \n 24 - Arrays \n"
                + " 25 - ArraysOperations \n 26 - Lists \n 27 - Dictionary \n 28 - Odd/even \n "
                + "29 - ReturnType \n -"
                + "Press the enter key to confirm. \nType \"exit\" to exit the program";
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
                    //in C# String are treated as objects so case "string" || "1": won't work so we need
                    //intermediate value and the when keyword
                    case string placeholder when placeholder == "string" || placeholder == "1":
                        Console.WriteLine("_______________________________________________\n");
                        StringChars.Program.StringLetters();
                        userInput = "";
                        break;
                    case string placeholder when placeholder == "numbers" || placeholder == "2":
                        Console.WriteLine("_______________________________________________\n");
                        Numbers.Program.Numbers();
                        userInput = "";
                        break;
                    case string placeholder when placeholder == "bool" || placeholder == "3":
                        Console.WriteLine("_______________________________________________\n");
                        Bool.Program.BoolExample();
                        userInput = "";
                        break;
                    case string placeholder when placeholder == "operations" || placeholder == "4":
                        Console.WriteLine("_______________________________________________\n");
                        Operations.Program.Operations();
                        userInput = "";
                        break;
                    case string placeholder when placeholder == "modulus" || placeholder == "5":
                        Console.WriteLine("_______________________________________________\n");
                        Modulus.Program.Modulus();
                        userInput = "";
                        break;
                    case string placeholder when placeholder == "var" || placeholder == "6":
                        Console.WriteLine("_______________________________________________\n");
                        VarEx.Program.VarEx();
                        userInput = "";
                        break;
                    case string placeholder when placeholder == "const" || placeholder == "7":
                        Console.WriteLine("_______________________________________________\n");
                        ConstEx.Programm.ConstEx();
                        userInput = "";
                        break;
                    case string placeholder when placeholder == "dataTypes" || placeholder == "8":
                        Console.WriteLine("_______________________________________________\n");
                        DataTypes.Programm.DemoFunction();
                        userInput = "";
                        break;
                    case string placeholder when placeholder == "username" || placeholder == "9":
                        Console.WriteLine("_______________________________________________\n");
                        UserInputName.Program.userInputsName();
                        userInput = "";
                        break;
                    case string placeholder when placeholder == "Guess the number" || placeholder == "10":
                        Console.WriteLine("_______________________________________________\n");
                        NumberGuess.Program.Demo();
                        userInput = "";
                        break;
                    case string placeholder when placeholder == "For loop" || placeholder == "11":
                        Console.WriteLine("_______________________________________________\n");
                        LoopFor.Program.Demo();
                        userInput = "";
                        break;
                    case string placeholder when placeholder == "While loop" || placeholder == "12":
                        Console.WriteLine("_______________________________________________\n");
                        LoopWhile.Program.Demo();
                        userInput = "";
                        break;
                    case string placeholder when placeholder == "Conditional operator" || placeholder == "Ternary Operator" || placeholder == "13":
                        Console.WriteLine("_______________________________________________\n");
                        ConditionalOperator.Program.Demo();
                        userInput = "";
                        break;
                    case string placeholder when placeholder == "format pattern" || placeholder == "14":
                        Console.WriteLine("_______________________________________________\n");
                        FormatPattern.Program.Demo();
                        userInput = "";
                        break;
                    case string placeholder when placeholder == "fizzbuzz" || placeholder == "15":
                        Console.WriteLine("_______________________________________________\n");
                        FizzBuzz.Program.Demo();
                        userInput = "";
                        break;
                    case string placeholder when placeholder == "verbatim" || placeholder == "16":
                        Console.WriteLine("_______________________________________________\n");
                        Verbatim.Program.Demo();
                        userInput = "";
                        break;
                    case string placeholder when placeholder == "stringFormat" || placeholder == "17":
                        Console.WriteLine("_______________________________________________\n");
                        stringFormat.Program.Demo();
                        userInput = "";
                        break;
                    case string placeholder when placeholder == "interpolation" || placeholder == "18":
                        Console.WriteLine("_______________________________________________\n");
                        Interpolation.Program.Demo();
                        userInput = "";
                        break;
                    case string placeholder when placeholder == "stringconcat" || placeholder == "19":
                        Console.WriteLine("_______________________________________________\n");
                        StringConcat.Program.Demo();
                        userInput = "";
                        break;
                    case string placeholder when placeholder == "equals" || placeholder == "20":
                        Console.WriteLine("_______________________________________________\n");
                        EqualsDemo.Programm.Demo();
                        userInput = "";
                        break;
                    case string placeholder when placeholder == "LoopIteration" || placeholder == "21":
                        Console.WriteLine("_______________________________________________\n");
                        LoopIteration.Program.Demo();
                        userInput = "";
                        break;
                    case string placeholder when placeholder == "EmptyOrNull" || placeholder == "22":
                        Console.WriteLine("_______________________________________________\n");
                        EmptyOrNull.Program.Demo();
                        userInput = "";
                        break;
                    case string placeholder when placeholder == "LoopReverse" || placeholder == "23":
                        Console.WriteLine("_______________________________________________\n");
                        LoopReverse.Program.Demo();
                        userInput = "";
                        break;
                    case string placeholder when placeholder == "Array" || placeholder == "24":
                        Console.WriteLine("_______________________________________________\n");
                        Arrays.Program.Demo();
                        userInput = "";
                        break;
                    case string placeholder when placeholder == "ArrayOperations" || placeholder == "25":
                        Console.WriteLine("_______________________________________________\n");
                        ArraysOperations.Program.Demo();
                        userInput = "";
                        break;
                    case string placeholder when placeholder == "Lists" || placeholder == "26":
                        Console.WriteLine("_______________________________________________\n");
                        Lists.Program.Demo();
                        userInput = "";
                        break;
                    case string placeholder when placeholder == "dictionary" || placeholder == "27":
                        Console.WriteLine("_______________________________________________\n");
                        Dictionnaries.Program.Demo();
                        userInput = "";
                        break;
                    case string placeholder when placeholder == "odd/even" || placeholder == "28":
                        Console.WriteLine("_______________________________________________\n");
                        ExerciceOddSplit.Program.Demo();
                        userInput = "";
                        break;
                    case string placeholder when placeholder == "returntype" || placeholder == "29":
                        Console.WriteLine("_______________________________________________\n");
                        ReturnType.Program.Print();
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
        public static void Numbers()  //static keyword means we don't have to create an instance of the class to call it, so no need to do
                //something like var newInstance = new Numbers.Program(); programInstance.Numbers();
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
            Console.WriteLine("the operation is :25 % 4");
            int number1 = 25;
            int number2 = 4;
            Console.WriteLine(number1 % number2 + "\nthis is the result"); //outputs 1 - Modulus very usefull to determine if 
            //odd number or not when using  %2
        }
    }
}

namespace VarEx
{
    class Program
    {
        public static void VarEx()
        {
            Console.WriteLine("var is a keyword wich tells the compiler to auto assign the datatype of"
                + " the variable based on its assigned value");
            var age = 266;
            Console.WriteLine(age + " ans. " + age.GetType().ToString());
            //Still have to put L if we want a int64 number
            var bigNumber = 8000000000L;
            Console.WriteLine(bigNumber + " " + bigNumber.GetType().ToString());
            var name = "Eddie";
            var letter = 'a';
            var negative = -25;
            var nDecimal = 12.265;
            Console.WriteLine(name + " " + name.GetType().ToString() + "\n" 
                + letter + " " + letter.GetType().ToString() + "\n"
                + negative + " " + negative.GetType().ToString() + "\n"
                + nDecimal + " " + nDecimal.GetType().ToString() + "\n");
            Console.WriteLine("Best to use var for obvious readable numbers like age or currency");
        }
    }
}

namespace ConstEx
{
    class Programm
    {
        public static void ConstEx()
        {
            const int vat = 20;
            const double percenVat = vat / 100D;
            int balance = 1000;
            //vat is a percentage so we need the D in 100 to not loose the decimal
            Console.WriteLine("Your balance is 1000 and you are buying a product with 20% vat, here is the VAT value\n");
            Console.WriteLine(balance * (vat / 100D) + " :this line the vat paid is calculated as balance * (vat / 100D)");
            Console.WriteLine(balance * percenVat + " :this line the vat paid is calculated the same way but (vat / 100D) is declared as a constant");
            Console.WriteLine("As an example constants can be usefull to declare the version number of a program");
        }
    }
}

namespace DataTypes
{
    class Programm
    {
        public static void DemoFunction()
        {
            Console.WriteLine("Be carefull with the type used to declare variable in a case situation where the user would input data");
            string name = "Eddie";
            int number = 0123456789; //In the CW the 0 disappears !!! Because it is an int. To make it appear make it as a string
            int age = 50;
            Console.WriteLine(name + "\n" + number + "\n" + age + "\n 123456789 is an int32, and that's how compiler treats 0123456789");
            string numberAsString = "0123456789";
            Console.WriteLine("___________________________________");
            Console.WriteLine(name + "\n" + numberAsString + "\n" + age + "\n0123456789 is not a number but actually a string !");
        }
    }
}

namespace UserInputName
{
    class Program
    {
        public static void userInputsName()
        {
            //cw push an /n terminator. If i want to display a message without a line skip i use Console.Write
            string userName;
            string age;
            Console.Write("Enter your name here:");
            userName = Console.ReadLine();
                Console.Write("\nEnter your age here:");
            age = Console.ReadLine();
            int ageInt = Convert.ToInt32(age);
            Console.WriteLine("Your name is " + userName + " and you are " + age + " years old"); //+ is a concatenation operator 
            Console.WriteLine("/ !\\ age is "+ age.GetType().ToString());
            if (ageInt >= 18)
            {
                Console.WriteLine("You are 18 or over. The age value that has been tested is the converted string into int :" + ageInt.GetType().ToString());
            }
            else if (ageInt > 18 && ageInt <= 30)
            {
                Console.WriteLine("You are between 19 and 30");
            }
        }
    }
}

namespace NumberGuess
{
    class Program
    {
        //private static int firstNumberConvert;
        //private static int secondNumberConvert;

        public static void Demo()
        {
            Console.WriteLine("Enter number One.");
            string firstNumber = Console.ReadLine();
            Console.WriteLine("Enter number Two");
            string secondNumber = Console.ReadLine();
            //In the block below we test if user actually puts a correct number and stop
            //the execution if the imput is incorrect. Putting a letter for example would break the
            //program and throw an exception so we try the convert and catch the error if it happens
            //try
            //{
            //    firstNumberConvert = Convert.ToInt32(firstNumber);
            //    secondNumberConvert = Convert.ToInt32(secondNumber);
            //}
            //catch (FormatException e)
            //{
            //    Console.WriteLine("Incorrect numbers, returning to menu.");
            //    return;
            //}

            bool pass1 = int.TryParse(firstNumber, out int firstNumberConvert); //If the conversion is Ok then string is output as an int as firstNumberConvert
            bool pass2 = int.TryParse(secondNumber, out int secondNumberConvert);

            if (pass1 != true || pass2 != true) { Console.WriteLine("Invalid number"); return; }

            Console.WriteLine("What is " + firstNumberConvert + "x" + secondNumberConvert + " ?");
            string answer = Console.ReadLine();
            int answerConverted = Convert.ToInt32(answer);
            if (answerConverted == (firstNumberConvert * secondNumberConvert))
            {
                Console.WriteLine("Bravo !");
            }
            else
            {
                Console.WriteLine("Try again");
            }
        }
    }
}

namespace LoopFor
{
    class Program
    {
        public static void Demo()
        {
            //we can use the same int i it won't break the program
            for (int i = 0; i < 10; i++) // start at 0, stops at 9 will be printed 9 times
            {
                Console.WriteLine("Hello");
            }
            for (int i = 0; i <= 10; i+=2)
            {
                Console.WriteLine(i);
            }

            Console.Write("How many times do you want to say hi ?:");

            string count = Console.ReadLine(); //Instead of doing what i did above i can 
            bool pass = int.TryParse(count, out int countConverted);
            if (!pass) { Console.WriteLine("Invalid number"); return; }

            //declare the int and use the convert operation on the console readline directly 
            for (int i = 0; i < countConverted; i++)
            {
                Console.WriteLine(i + " - Hi!");
            }
            Console.WriteLine("Now decide what you want to write and how many times it will be repeated");

            Console.Write("How many prints ? (above 0)");
            string count2 = Console.ReadLine();
            bool pass2 = int.TryParse(count2, out int countConverted2);
            if (!pass2){ Console.WriteLine("Invalid number");return; }
            if (countConverted2 == 0)
            {
                Console.WriteLine("Operation aborted.");
                return;
            }
            Console.WriteLine("Write your message in the new line");
            string msg = Console.ReadLine();
            for (int i = 1;i < countConverted2; i++) // starts as because we i++ if 0 then we
                //have 1 more over the limit
            {
                Console.WriteLine(msg);
            }
        }
    }
}

namespace LoopWhile
{
    class Program
    {
        //private static int firstNumberConverted;
        //private static int secondNumberConverted;
        public static void Demo()
        {
            //int i = 0;
            //while(i < 10)
            //{
            //    i++; // 9 prints from 1 to 10
            //    Console.WriteLine(i);
            //    // i++; 9 prints from 0 to 9
            //}
            Console.WriteLine("Enter number One.");
            string firstNumber = Console.ReadLine();
            Console.WriteLine("Enter number Two");
            string secondNumber = Console.ReadLine();

            bool pass1 = int.TryParse(firstNumber, out int firstNumberConverted);
            bool pass2 = int.TryParse(secondNumber, out int secondNumberConverted);

            if (!pass1 || !pass2){ Console.WriteLine("Invalid number somewhere");return;}

            Console.WriteLine("What is " + firstNumberConverted + "x" + secondNumberConverted + " ?");
            Console.WriteLine("Type \"exit\" if you want to quit");
            Console.WriteLine(); //empty line for readability 
            int answerConverted;
            //while (answerConverted != firstNumberConvert * secondNumberConvert)
            //{
            //    if (answerConverted != (firstNumberConvert * secondNumberConvert))
            //    {
            //        Console.WriteLine("Try again!");
            //        answer = Console.ReadLine();
            //        answerConverted = Convert.ToInt32(answer);
            //    }
            //}
            //Console.WriteLine("Bravo!");

            do //what is in the braces will run until the while condition is respected
                //Actually a more suitable option in this case because we want the user to always input 
                //something
            {
                string answer = Console.ReadLine();
                if (answer.ToLower() == "exit")
                {
                    return;
                }
                bool pass3 = int.TryParse(answer, out answerConverted);
                if (!pass3) Console.WriteLine("NaN");
                if (answerConverted != firstNumberConverted * secondNumberConverted)
                {
                    Console.WriteLine("Try again!");
                }
            } while (answerConverted != firstNumberConverted * secondNumberConverted);
            Console.WriteLine("Bravo!");
        }
    }
}

namespace ConditionalOperator
{
    class Program
    {
        public static void Demo()
        {
            Console.Write("Enter an age: ");
            string age = Console.ReadLine();
            //without the previous pass intermediate value 
            if (int.TryParse(age, out int ageConverted))
            {
                //it's better for the memory to print it right away 
                Console.WriteLine(ageConverted > 10 ? "Valid" : "Invalid");
                Console.WriteLine("The if operation is written in the code as :\n Console.WriteLine(ageConverted > 10 ? \"Valid\" : \"Invalid\");");
            }
            else
            {
                Console.WriteLine("NaN");
            }
        }
    }
}

namespace FormatPattern
{
    class Program
    {
        public static void Demo()
        {
            //I need this line because the font in my consonsole doesn't display € natively
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Here is an exemple of numeric formating"
                 + "\n1000/12.34");
            double value = 1000D / 12.34D;
            Console.WriteLine(value);
            Console.WriteLine(string.Format("{0:0.00}",value));  //0 represents the first value, the 0:00
                                                                 //mean we want to round up up to two decimals
            Console.WriteLine(string.Format("{0:0.0}", value));
            Console.WriteLine(string.Format("{0:0.#}", value)); //hashtag trim any 0
            Console.WriteLine(string.Format("{0:0.0#}", value));//at 2 decimals it's not a whol number so no 0 trim 
            //Thread.CurrentThread.CurrentCulture = new CultureInfo("fr-FR");
            double moni = 10D / 3D;
            Console.WriteLine(String.Format("{0:0.00} €", moni));
            //What if we want to display negative currency as if it was a balance change ? 
            Console.WriteLine();
            double moniNegative = -10D / 3D;
            Console.WriteLine(String.Format("{0:0.00} €", moni));
            Console.WriteLine(moniNegative.ToString("C")); //C is a format to display a currency

            Console.WriteLine(moniNegative.ToString("C", CultureInfo.CurrentCulture)); //That's the C format of the CurentCulture
            Console.WriteLine(moniNegative.ToString("C", CultureInfo.CreateSpecificCulture("en-US")) + " English US");
            Console.WriteLine(moniNegative.ToString("C", CultureInfo.CreateSpecificCulture("en-AU")) + " English AUS");
            Console.WriteLine(moniNegative.ToString("C", CultureInfo.CreateSpecificCulture("en-NZ")) + " English NZ");


        }
    }
}

namespace FizzBuzz
{
    class Program
    {
        public static void Demo()
        {
            /*
             * Create a loop from 1 to X
             * Divisible by 3 AND 5 = FizzBuzz
             * Divisible by 3 = Fizz
             * Divisible by 5 = Buzz
             */
            bool threeDiv = false;
            bool fiveDiv = false;
            Console.Write("Loop from 1 to X. Enter X. X = ?");
            if (!int.TryParse(Console.ReadLine(), out int answerConvereted)) Console.WriteLine("Invalid");
            for (int i = 1; i <= answerConvereted;i++)
            {
                threeDiv = i % 3 == 0;
                fiveDiv = i % 5 == 0;
                if (threeDiv && fiveDiv)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (threeDiv)
                {
                    Console.WriteLine("Fizz");
                }
                else if (fiveDiv)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

namespace Verbatim
{
    class Program
    {
        public static void Demo()
        {
            string path = "C:Users\\Jean\\Documents \n New line";
            Console.WriteLine(path);
            Console.WriteLine("I am using the verbatim identifier in this path below");
            path = @"C:Users\\Jean\\Documents" + "\n New line";
            //Verbatim won't work with \n and escape characters need to use concatenation 
            Console.WriteLine(path);
            //speech mark in verbatim identifier needs double speech mark
            string exemple = @"Hello ""Someone""";
            Console.WriteLine(exemple);
            exemple = "Hello 'someone'";
            Console.WriteLine(exemple);
        }
    }
}

namespace stringFormat
{
    class Program
    {
        public static void Demo()
        {
            string age = "50";
            string name = "Eddie";
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Age : " + age);
            Console.WriteLine("Your name is " + name + " and your age is " + age +".");
            Console.WriteLine("[----------------------------------]");
            Console.WriteLine("Your name is {0} and your age is {1}.", name, age);
        }
    }
}

namespace Interpolation
{
    class Program
    {
        public static void Demo()
        {
            string age = "50";
            string name = "Eddie";
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Age : " + age);
            Console.WriteLine("Your name is " + name + " and your age is " + age + ".");
            Console.WriteLine("[----------------------------------]");
            Console.WriteLine($"Your name is {name} and your age is {age}.");
        }
    }
}

namespace StringConcat
{
    class Program
    {
        public static void Demo()
        {
            string age = "50";
            string name = "Eddie";
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Age : " + age);
            Console.WriteLine("Your name is " + name + " and your age is " + age + ".");
            Console.WriteLine("[----------------------------------]");
            Console.WriteLine(string.Concat("Your name is ",name," and your age is ",age,"."));
        }
    }
}

namespace EqualsDemo
{
    class Programm
    {
        public static void Demo()
        {
            string nameProg = "Brok";
            char[] chars = new char[] { 'B', 'r', 'o', 'k' };
            Console.WriteLine($"Hello my name is {nameProg}. What's yours ?");
            Console.Write("I am (enter your name):");
            string nameUser = Console.ReadLine();
            object newCompare = new string(chars);

            if (!nameUser.Equals(string.Empty))
            {
                Console.WriteLine("below comparing string strings");
                if (nameUser.Equals(nameProg))
                {
                    Console.WriteLine("We have the same name !");
                }
                else
                {
                    Console.WriteLine("We are not called the same");
                }

                Console.WriteLine("Below using string.Eqals. Comparing object Brok holding array of chars to string");
                if (nameUser.Equals(newCompare))
                {
                    Console.WriteLine("We have the same name!");
                }
                else
                {
                    Console.WriteLine("We are not the same");
                }
                Console.WriteLine("Below using == and same values used");

                if (nameUser == newCompare)
                {
                    Console.WriteLine("Same name");
                }
                else
                {
                    Console.WriteLine("not");
                }
                Console.WriteLine($"\nEquals compare the values and the == operator compares the reference in the memory." +
                    $"Best to use equals because it cares more about the values rather than where they are in the memory\n");
            }
        }
    }
}

namespace LoopIteration
{
    class Program
    {
        public static void Demo()
        {
            //Keep in my a string is an array of char 
            string msg = "This is a message";
            for (int i = 0; i < msg.Length; i++)
            {
                Console.Write(msg[i]);
                System.Threading.Thread.Sleep(200); //Makes the program wait 
            }
            Console.WriteLine();
            Console.WriteLine(msg.Contains('a')); // displays true if contains a 
            bool contains = false;
            for (int i = 0; i < msg.Length; i++)
            {
                if (msg[i] == 'a') 
                {
                    contains = true;
                }
            }
            Console.WriteLine(contains);
        }
    }
}

namespace EmptyOrNull
{
    class Program
    {
        public static void Demo()
        {
            Console.WriteLine("what's yo name ?");
            string name = Console.ReadLine();

            //if (name != "")
            //{
            //  Console.WriteLine("Empty");
            //}

            //if (!name.Equals(""))
            //{
            //  Console.Writeline("Empty");
            //}

            if (!string.IsNullOrEmpty(name))
            {
                if (name.Equals("Magic"))
                {
                    Console.WriteLine("Yay!");
                }
                else
                {
                    Console.WriteLine("Nay!");
                }
            }
        }
    }
}

namespace LoopReverse
{
    class Program
    {
        public static void Demo()
        {
            string msg = Console.ReadLine();
            for (int i = 0;i < msg.Length;i++)
            {
                Console.Write(msg[i]);
            }

            Console.WriteLine("\nNow the reverse\n");

            for (int i = msg.Length - 1;i >= 0;i--) //Looping through all indexes but starting at the end 
            {
                Console.Write(msg[i]);
            }
            Console.WriteLine();
        }
    }
}

namespace Arrays
{
    class Program
    {
        public static void Demo()
        {
            int number1 = 5;
            int number2 = 10;
            int number3 = 15;

            int[] numbersArray = new int[10]; // To declare an array use the bracket notation after
            //datatype and instantiate it with the amount of indexes you want 
            //Console.WriteLine($"{number1} & {number2} & {number3}");
            //Console.WriteLine($"{numbersArray[0]} & {numbersArray[1]} & {numbersArray[2]}");
            Console.Write("Length of the loop ?");
            int loopLen = Convert.ToInt32(Console.ReadLine());
            Array.Resize(ref numbersArray, loopLen);
            for (int i = 0; i < numbersArray.Length; i++)
            {
                Console.Write("Enter a number: ");
                numbersArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            for (int i = 0; i < numbersArray.Length;i++)
            {
                Console.Write($"{numbersArray[i]} ");
            }
            Console.WriteLine();
            foreach (int num in numbersArray) //More suited when yuo know you need to loop through all the array
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine();
        }
    }
}

namespace ArraysOperations
{
    class Program
    {
        public static void Demo()
        {
            int[] numbers = new int[] { 4, 51, 6, 84 }; //syntax to declarearray without len
            foreach (int num in numbers)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine() ;
            Console.WriteLine("Sort");

            //int[] arraySorted = Array.Sort(numbers);
            //if i want to keep original array i need to do something like this 
            int[] arraySorted = (int[])numbers.Clone();
            Array.Sort(arraySorted);
            foreach (int num in arraySorted)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine("");
            Console.WriteLine("Reverse");
            int[] arrayReversed = (int[])numbers.Clone();
            Array.Reverse(arrayReversed);
            Array.Reverse(numbers);
            foreach (int num in arrayReversed)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine();
            Console.WriteLine("Clearing");
            int[] arrayCleared = (int[])numbers.Clone();
            Array.Clear(arrayCleared,0,arrayCleared.Length);
            foreach(var something in  arrayCleared)
            {
                Console.Write(something);
            }
            //Default value of int is 0
            Console.WriteLine();

            Console.Write("What number do you want to search ?:");
            int nbToSeatch = Convert.ToInt32(Console.ReadLine());
            int position = Array.IndexOf(numbers, nbToSeatch); 
            if (position >= 0)
            {
                Console.WriteLine($"Number {nbToSeatch} has been found at {position}");
            }
            else
            {
                Console.WriteLine($"number {nbToSeatch} has not been found");
            }
        }
    }
}

namespace Lists
{
    class Program
    {
        public static void Demo()
        {
            //Lists act like modular arrays
            int[] numbers = { 1, 45, 6, 9 };

            List<int> listNumbers = new List<int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Enter a number: ");
                listNumbers.Add(Convert.ToInt32(Console.ReadLine()));
            }
            Console.WriteLine();
            for (int i = 0;i < listNumbers.Count;i++)
            {
                Console.Write($"{listNumbers[i]}");
            }
            Console.WriteLine() ;
            listNumbers.RemoveAt(0);
            foreach(var item in  listNumbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}

namespace Dictionnaries
{
    class Program
    {
        public static void Demo()
        {
            Dictionary<int, string> names = new Dictionary<int, string>//with and ID comes a name
            //T means any data
            //all keys must be unique else runtime error 
            {
                {1,"Anthony"},
                {2, "Test" },
                {3, "Test" } //Key value pair
            };
            for (int i = 0; i < names.Count; i++)
            {
                //Console.WriteLine(names[i]);//will return only "anthony" 3 times because we
                KeyValuePair<int,string> pair = names.ElementAt(i);
                Console.WriteLine(names.ElementAt(i));
                Console.WriteLine($"{pair.Key} - {pair.Value}");
            }
            Console.WriteLine();


            Dictionary<string, string> teachers = new Dictionary<string, string>
            {
                {"Maths","Henri"},
                {"Français","Lina"}
            };
            //Console.WriteLine(teachers["Maths"]); //problem with this approche is that one typo and the programm crashes
            if (teachers.TryGetValue("Maths", out string teacher))
            {
                Console.WriteLine(teacher);
                teachers["Maths"] = "Joe";
                System.Threading.Thread.Sleep(500);
                Console.WriteLine(teacher);
            }
            else
            {
                Console.WriteLine("teacher not found");
            }
            teachers.Remove("Maths");
            foreach (var item in teachers)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
            if (teachers.ContainsKey("Math")) Console.WriteLine("Maths teacher has been fired");
        }
    }
}

namespace ExerciceOddSplit
{
    class Program
    {
        public static void Demo()
        {
            //using lists are more flexible, more dynamic
            List<int> odd = new List<int>();
            List<int> even = new List<int>();
            for (int i = 0; i <= 20; i++)
            {
                if (i % 2 == 0) { even.Add(i); }
                else{ odd.Add(i); } // modulus 2 always 1 or 0
            }
            Console.WriteLine();
            foreach (var oddity in odd)
            {
                Console.Write($"{oddity} ");
            }
            Console.WriteLine();
            foreach (var eveny in even)
            {
                Console.Write($"{eveny} ");
            }
        }
    }
}

namespace ExerciceDict
{
    class Program
    {
        public static void Demo()
        {
            /*
             * Define and initialize two integers num, len
             * (7,5)->[7,14,21,28,35]
             * Create int array with size length
             * loop through and insert the (loop counter x num) into the array
             * print the final array
             */

            int num = 7;
            int len = 5;
            int[] numbers = new int[len];

            //int counter = 0;

            for (int i = 0;i <numbers.Length; i++/*, counter++*/)
            {
                numbers[i - 1] = num * i; ///without minus 1 then error out of index 
                //counter++;
            }
            foreach (var item in numbers)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}

namespace ReturnType
{
    class Program
    {
        public static void Print()
        {
            Console.WriteLine(Demo()); // not like in PHP where it would be something like $this->Print()
        }
    public static string Demo()
            {
                return "This dunction returns a string!";
            }
    }
}