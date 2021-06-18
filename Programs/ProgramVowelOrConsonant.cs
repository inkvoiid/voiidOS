using System;
using System.Collections.Generic;
using System.Text;

namespace voiidOS.Programs
{
    class ProgramVowelOrConsonant
    {
        public void Run()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Vowel or Consonant Checker");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

            string char1;

            void checkInput()
            {
                Console.Write("Enter a character: ");
                char1 = Console.ReadLine().Replace(" ", "");

                if (string.IsNullOrWhiteSpace(char1))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nError: Character can't be blank!");
                    Console.ForegroundColor = ConsoleColor.White;
                    checkInput();
                }

                if (Char.IsLetter(char1[0]) == false)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nError: Character is invalid!");
                    Console.ForegroundColor = ConsoleColor.White;
                    checkInput();
                }
            }
            checkInput();
            if (char1.Length > 1)
            {
                Console.WriteLine("\nGrabbing only the first character which is: \"{0}\"", char1[0]);
            }

            switch (char1[0])
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                case 'A':
                case 'E':
                case 'I':
                case 'O':
                case 'U':
                    Console.WriteLine("\nThe letter {0} is a vowel", char1[0]);
                    break;


                default:
                    Console.WriteLine("\nThe letter {0} is a consonant", char1[0]);
                    break;

            }
        }
    }
}
