using System;

namespace C_Sharp_Intro
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine( "Enter a number:" );
            int userInt = Int32.Parse( Console.ReadLine() );
            if ( userInt > 5 )
            {
                Console.WriteLine( "Greater than 5." );
            }
            else if ( userInt > 10 )
            {
                Console.WriteLine( "Greater than 10." );
            }
            else if ( userInt < 0 )
            {
                Console.WriteLine( "A negative number." );
            }
            else
            {
                Console.WriteLine( "Number is between 0 and 5." );
            }
        }
    }
}
