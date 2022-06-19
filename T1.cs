/*
Task One - Calculator:
You will create a set of Math operators (+, -, /, *, pow and remainder) by getting the TWO input numbers
from the user and printing out the result on the command windows in MS Visual Studio 2022 community,
each Math operator result must be printed in a different background and foreground color.

Not using Studio bc it is new, confuses me, and I find it unecessary since I'm solid with VS Code
That beind said I never had node.js installed on this system so there will be no testing, just praying
*/

using System;       // Origin of our namespace and classes

namespace Calculator        // The container for the proceeding classes
{
    class CalcMath          // Class #1
    {
        static void Main(string[] args)                 // First Operator or Class Method, just a string to start out the process
        {
        Console.Writeline("Feed Me Your Maths");
        }
 
        public int Sum (double x, double y)             // Second Operator for Addition
        {
            
            Console.backgroundColour = ConsoleColor.DarkGreen;      //Each mathmetical operator has it's own base colour as requested
            Console.foregroundColour = ConsoleColor.Black;          //Decided to keep the forground colour the same
            return x + y;                                           //The return expected of the operator
            Console.Writeline(Sum);                                 //The console method to return the answer of the operator
        }                                                           //Given that the assignment only requires to combination of TWO variables,
                                                                    // I'm not sure how much more this needs to be fleshed out
    
        public int Sub (double x, double y)             // Third for Subtraction
        {

            Console.backgroundColour = ConsoleColor.DarkRed;
            Console.foregroundColour = ConsoleColor.Black;
            return x - y;
            Console.Writeline(Sub);

        }
       
        public int Multi (double x, double y)           // Fourth for Multiplication
        {

            Console.backgroundColour = ConsoleColor.Magenta;
            Console.foregroundColour = ConsoleColor.Black;
            return x * y;
            Console.Writeline(Multi);

        } 

        public int Dev (double x, double y)             //Fifth for Devision
        {

            Console.backgroundColour = ConsoleColor.Blue;
            Console.foregroundColour = ConsoleColor.Black;
            return x / y;
            Console.Writeline(Dev);


        }
    
        public int Pow (double x, double y)             // Sixth for Exponentials
        {

            Console.backgroundColour = ConsoleColor.Cyan;
            Console.foregroundColour = ConsoleColor.Black;
            return x ^ y;
            Console.Writeline(Pow);

        }

        public int Rem (double x, double y)             // Seventh for "Remainders"
        {

            Console.backgroundColour = ConsoleColor.DarkGray;
            Console.foregroundColour = ConsoleColor.Black;
            return x % y;
            Console.Writeline(Rem);

        }

    }                                                   //Was going to add a PemDas Class that can access other operators but 
                                                        //upon further research the C# compiler follows this process already.

    
}