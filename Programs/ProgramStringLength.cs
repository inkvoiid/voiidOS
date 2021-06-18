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
            if((input.Length - input.Replace(" ", "").Length) == 1)
            {
                Console.WriteLine("The string is {0} characters and {1} space long", input.Replace(" ", "").Length, (input.Length - input.Replace(" ", "").Length));
            }
            else
            {
                Console.WriteLine("The string is {0} characters and {1} spaces long", input.Replace(" ", "").Length, (input.Length - input.Replace(" ", "").Length));
            }
            

            Console.WriteLine("");
        }
    }
}
