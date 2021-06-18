using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace voiidOS
{
    class Program
    {
        static void Main(string[] args)
        {
            // Top
            Console.BackgroundColor = ConsoleColor.Black;

            void aboutOS()
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" _    __      _ _     ______  _____©");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("| |  / /___  (_|_)___/ / __ \\/ ___/");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("| | / / __ \\/ / / __  / / / /\\__ \\");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("| |/ / /_/ / / / /_/ / /_/ /___/ / ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write("|___/\\____/_/_/\\__,_/\\____//____/");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(" Now in C#!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("");
                Console.WriteLine("Version b3.0 | Copyright VOIID Inc. 2021");
                Console.WriteLine("");
            }
            aboutOS();

            int userNum = 100;
            List<User> voiidUser = new List<User>();
            voiidUser.Add(new User("inkvoiid", "voo", true));
            voiidUser.Add(new User("DumbleDog_", "pig", false));


            string shrink(string input) 
            {
                return input.ToLower().Replace(" ", "");
            }

            //Login and shutdown

            void Login()
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("Login");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;

                Console.Write("|");

                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Shutdown");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;

                Console.Write("Select your option: ");

                Console.ForegroundColor = ConsoleColor.Yellow;
                string loginOrShutdown = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();

                // While loop for if input is out of bounds

                while (shrink(loginOrShutdown) != "login" & shrink(loginOrShutdown) != "shutdown")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error: Not an option");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Select your option: ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    loginOrShutdown = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.White;
                }

                // If statement for either login or shutdown using cool shrink function

                if (shrink(loginOrShutdown) == "shutdown")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Project: VoiidOS terminated due to shutdown signal by user.");
                    Console.Write("Press any key to continue");
                    Console.ReadKey();
                    Console.ForegroundColor = ConsoleColor.White;
                    Environment.Exit(0);
                }
                else if (shrink(loginOrShutdown) == "login")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Users:");
                    Console.ForegroundColor = ConsoleColor.White;
                    //List all users with separator between that breaks before the end
                    int userGapCounter = 0;
                    foreach (var user in voiidUser)
                    {
                        userGapCounter++;
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write(user.username);
                        Console.ForegroundColor = ConsoleColor.White;
                        if (userGapCounter==voiidUser.Count)
                        {
                            Console.WriteLine();
                            break;
                        }
                        Console.Write(" | ");
                    }

                    // Actually login
                    Console.Write("\nEnter your username: ");

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    string uNameInput = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    
                    int i = 0;
                    foreach (var user in voiidUser)
                    {

                        if (uNameInput == user.username)
                        {
                            userNum = i;
                            break;
                        }
                        if (i < voiidUser.Count-1)
                        {
                            i++;
                        }
                    }
                    while (uNameInput != voiidUser[i].username)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nError: User Not Found");
                        Console.ForegroundColor = ConsoleColor.White;

                        Console.Write("Enter your username: ");

                        Console.ForegroundColor = ConsoleColor.Cyan;
                        uNameInput = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.White;

                        i = 0;
                        foreach (var user in voiidUser)
                        {

                            if (uNameInput == user.username)
                            {
                                userNum = i;
                                break;
                            }
                            if (i < voiidUser.Count - 1)
                            {
                                i++;
                            }
                        }
                    }

                    if (voiidUser[userNum].checkPassword() == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Access Granted.");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("Welcome, ");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write(voiidUser[userNum].username);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(".\n");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nYou have entered an incorrect password too many times.");
                        Console.WriteLine("\nProject: VoiidOS terminated due to potential data breach.");
                        Console.Write("Press any key to continue");
                        Console.ReadKey();
                        Console.ForegroundColor = ConsoleColor.White;
                        Environment.Exit(0);
                    }
                }
            }

            Login();


            Programs.ProgramStringLength stringLength = new Programs.ProgramStringLength();
            Programs.ProgramVowelOrConsonant vowelOrConsonant = new Programs.ProgramVowelOrConsonant();
            
            List<Action> programs = new List<Action>();
            programs.Add(stringLength.Run);
            programs.Add(vowelOrConsonant.Run);

            void desktopUI()
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("\n{0}'s Desktop:", voiidUser[userNum].username);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nInstalled Programs:");

                int progNum = 1;
                foreach (var program in programs)
                {
                    Console.Write("{0}: {1}",progNum,program);
                }

                //Console.WriteLine();
                //string run, directRun;
                //do
                //{
                //    Console.Write("Enter a Program Number to run: ");
                //    Console.ForegroundColor = ConsoleColor.Yellow;
                //    run = Console.ReadLine();
                //    Console.ForegroundColor = ConsoleColor.White;
                //    directRun = run.ToLower().Replace(" ", "");
                //    Console.WriteLine();
                //    switch (directRun)
                //    {
                //        case "1":
                //            DefaultPrograms.vowelOrConsonant();
                //            break;
                //        default:
                //            Console.ForegroundColor = ConsoleColor.Red;
                //            Console.WriteLine("That is not an installled program.");
                //            Console.ForegroundColor = ConsoleColor.White;
                //            break;
                //    }
                //}
                //while (directRun != "shutdown");
                //Environment.Exit(0);
            }
            desktopUI();

            Console.ReadKey();
        }
    }



}
