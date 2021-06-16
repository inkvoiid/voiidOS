using System;
using System.Collections.Generic;
using System.Text;

namespace voiidOS.Programs
{
    class ProgramStringLength
    {
        public void Run()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("String Length Counter");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Enter a string to be counted: ");

            Console.ForegroundColor = ConsoleColor.Yellow;
            string input = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("The string is {0} characters long with {1} spaces", input.Length, (input.Length - input.Replace(" ", "").Length));

            Console.WriteLine("");
        }
    }
}
