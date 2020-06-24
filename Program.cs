using System;

namespace C_Sharp_Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            // Two slashes mark the beginning of a single-line comment.
            // We are assigning a string value to a variable.
            string myName = "Dinh Thai";
            /* We begin multi-line comments with a forward slash and asterisk...

            Symbols between values or evaluations are considered "operators." 
            Below we are using the addition symbol to concatenate two strings.
            (Concatentation means gluing two strings, or texts, together.)

            ...and we end multi-line comments with an asterisk follow by a forward slash */
            Console.WriteLine("Hello, " + myName);

            Console.WriteLine("Please enter you name...");
            // Assign variable 'username' to a value entered by the user.
            //@link https://docs.microsoft.com/en-us/dotnet/api/system.console.readline?view=netcore-3.1
            string userName = Console.ReadLine();
            // Show the user we collected the name.
            Console.WriteLine("You have entered:" + userName);
            // Instead of traditional concatenation using the addition operator...
            // We can use string interpolation (placeholders) to embed values in
            // a string!
            // @link https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/interpolated
            Console.WriteLine("Hey {0}, you're looking great today!", userName);

            // Let's play with strings!
            Console.WriteLine( "makemeuppercase".ToUpper() );
            Console.WriteLine( "MAKEMELOWERCASE".ToLower() );
            // Substring takes two arguments: 1) Starting character position  2) Number of characters to collect.
            Console.WriteLine( "ABCDEFGHIJKLMNOPQRSTUVWXYZ".Substring( 3, 3) );
            Console.WriteLine( "XYZ".Length ); // Get the number of characters for the string.
        }
    }
}
