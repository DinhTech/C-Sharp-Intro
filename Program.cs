using System;

namespace C_Sharp_Intro
{
    class Program
    {
        static void Main(string[] args)
        {
           // It is a good idea, for user experience, to prompt the user.
           // Guiding the user is great, as it tells them what is expected.
           Console.WriteLine( "Please enter a string:");
           string userInput = Console.ReadLine(); // Assignment; collecting data from the user.
           
           // We can use "if" statement to check a "condition".
           // if the "if statement" is true, its code block (marked by curly braces {} will execute.)
           if ( userInput.Length > 0 )
           {
               Console.WriteLine( "The user entered a value." );
           }
           // If there is an "else" statement proceeding an "if", it will only execute if the "if statement" was false.
           else
           {
               Console.WriteLine( "The user did not entered a value." );
           }
        }
    }
}
