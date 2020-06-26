using System;

namespace C_Sharp_Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2 dimensional array!
            string[,] topics = {{"cat","dog","frog","hedgehog"},
                                {"zebra","giraffe","lion","elephant"},
                                {"zebra","giraffe","lion","elephant"},
                                {"ant","beetle","waterbug","mosquito"}};
            // Loop through the rows...
            for( int row = 0; row < topics.GetLength(0); row++ ) // row = row + 1;
            {
                // Output current row...
                Console.WriteLine( "Starting row #{0}", row );
                // Loop through column in the current row...
                for ( int column = 0; column < topics.GetLength(1); column++ )
                {
                    // Output the current column...
                    Console.WriteLine( "Starting column #{0}", column );
                    // Output the current animal!
                    Console.WriteLine( "This animal is: {0}", topics[row,column] );
                }
                
            }                
        }
    }
}
