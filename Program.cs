using System;

namespace C_Sharp_Intro
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine( "Please type: (add/subtract/exit)" );
           string command; // Declare a variable.
           // Accept commands.
           while( ( command = Console.ReadLine() )  != "exit" )      
           {
               int result;
               if ( command == "add" )
               {
                   Console.WriteLine( "Enter first number to add:" );
                   int firstNum = int.Parse( Console.ReadLine() );
                   Console.WriteLine( "Enter second number to add:" );
                   int secondNum = int.Parse( Console.ReadLine() );
                   result = Addition( firstNum, secondNum );
               }
               else if ( command == "subtract" )
               {
                   Console.WriteLine( "Enter first number to add:" );
                   int firstNum = int.Parse( Console.ReadLine() );
                   Console.WriteLine( "Enter second number to add:" );
                   int secondNum = int.Parse( Console.ReadLine() );
                   result = Addition( firstNum, secondNum );
               }
               else
               {
                   Console.WriteLine( "Invalid command, please try again." );
               }
               Console.WriteLine( "please enter a command: add/subtract/exit" );
           } // End of the while loop.
        }

        static int Addition( int num1, int num2 )
        {
            return num1 + num2;
        }

        static int Subtraction( int num1, int num2 )
        {
            return num1 - num2;
        }
    }
}
