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
        }
    }
}
