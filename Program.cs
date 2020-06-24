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
            string userName = Console.ReadLine();
            // Show the user we collected the name.
            Console.WriteLine("You have entered:" + userName);
            // Instead of traditional concatenation using the addition operator...
            // We can use string interpolation (placeholders) to embed values in
            // a string!
            Console.WriteLine("Hey {0}, you're looking great today!", userName);
        }
    }
}
