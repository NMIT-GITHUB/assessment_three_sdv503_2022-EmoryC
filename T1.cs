/*
Task One - Calculator:
You will create a set of Math operators (+, -, /, *, pow and remainder) by getting the TWO input numbers
from the user and printing out the result on the command windows in MS Visual Studio 2022 community,
each Math operator result must be printed in a different background and foreground color.

Not using Studio bc it is new, confuses me, and I find it unecessary since I'm solid with VS Code
That beind said I never had node.js installed on this system so there will be no testing, just praying
*/

using System;

namespace Calculator
{
    class CalcMath
    {
        static void Main(string[] args)
        {
        Console.Writeline("Feed Me Your Maths");
        }
 
        public int Sum (double x, double y)
        {
            
            Console.backgroundColour = ConsoleColor.DarkGreen;
            Console.foregroundColour = ConsoleColor.Black;
            return x + y;
            
        }
    
        public int Sub (double x, double y)
        {

            Console.backgroundColour = ConsoleColor.DarkRed;
            Console.foregroundColour = ConsoleColor.Black;
            return x - y;

        }
       
        public int Multi (double x, double y)
        {

            Console.backgroundColour = ConsoleColor.Magenta;
            Console.foregroundColour = ConsoleColor.Black;
            return x * y;

        }

        public int Dev (double x, double y)
        {

            Console.backgroundColour = ConsoleColor.Blue;
            Console.foregroundColour = ConsoleColor.Black;
            return x / y;

        }
    
        public int Pow (double x, double y)
        {

            Console.backgroundColour = ConsoleColor.Cyan;
            Console.foregroundColour = ConsoleColor.Black;
            return x ^ y;

        }

        public int Rem (double x, double y)
        {

            Console.backgroundColour = ConsoleColor.DarkGray;
            Console.foregroundColour = ConsoleColor.Black;
            return x % y;

        }


    }

}