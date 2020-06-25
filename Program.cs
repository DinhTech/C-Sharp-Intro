using System;

namespace C_Sharp_Intro
{
    class Program
    {
        static void Main(string[] args)
        {
           int myNum = 3;
           while ( myNum > 0 ) // Iterates/loops while the CONDITION is TRUE.
           {
               Console.WriteLine( "Current number is: {0}", myNum );
               myNum--;
           }
           /*
                For loops have 3 semi-colon-separated components;
                1) Assignment.
                2) [ Termination ] Condition.
                3) Iteration.
           */
           //@link https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/foreach-in
           for ( int i = 0; i < 6; i += 2 )
           {
               Console.WriteLine( "Current (for) number is: {0}", i );
           }

           string[] myList = { "cat", "turtle", "lizard", "frog", "dog" };
           foreach ( string listItem in myList )
           {
               Console.WriteLine( "The current item is: {0}", listItem );
           }
        }
    }
}
