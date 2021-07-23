using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Text = voiidOS.Utils.Text;

namespace voiidOS
{
    class Program
    {
        static void Main(string[] args)
        {
            // Top
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
                Console.WriteLine("Version b3.0 | © inkvoiid 2021");
                Console.WriteLine("");
            }
            aboutOS();

            //Set userNum
            int userNum = -1;

            //Create a list of user and add create them inside the list.
            List<User> voiidUser = new List<User>();
            voiidUser.Add(new User("inkvoiid", "voo", true));
            voiidUser.Add(new User("DumbleDog_", "pig", false));



            //Login and shutdown

            void Login()
            {
                //Login or shutdown options
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Login");
                Console.ResetColor();
                Console.Write(" | ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Shutdown");
                Console.ResetColor();
                Console.WriteLine();

                //Gets input and shrinks it.
                Console.Write("Select your option: ");

                Console.ForegroundColor = ConsoleColor.Yellow;
                string loginOrShutdown = Text.Shrink(Console.ReadLine());
                Console.ResetColor();


                // While loop for if input is out of bounds
                while (loginOrShutdown != "login" & loginOrShutdown != "shutdown")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error: Not an option");
                    Console.ResetColor();
                    Console.Write("Select your option: ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    loginOrShutdown = Text.Shrink(Console.ReadLine());
                    Console.ResetColor();
                }

                // If statement for either login or shutdown using cool shrink function
                if (loginOrShutdown == "shutdown")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Project: VoiidOS terminated due to shutdown signal by user.");
                    Console.Write("Press any key to continue");
                    Console.ReadKey();
                    Console.ForegroundColor = ConsoleColor.White;
                    Environment.Exit(0);
                }
                else if (loginOrShutdown == "login")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nUsers:");
                    Console.ForegroundColor = ConsoleColor.White;

                    //List all users with separator between that breaks before the end
                    int userGapCounter = 0;
                    foreach (User user in voiidUser)
                    {
                        userGapCounter++;
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write(user.username);
                        Console.ResetColor();
                        if (userGapCounter==voiidUser.Count)
                        {
                            Console.WriteLine();
                            break;
                        }
                        Console.Write(" | ");
                    }

                    //Set userNum to -1 for logging out users to switch user
                    userNum = -1;

                    // Actually login
                    void usernameSelect()
                    {
                        Console.Write("\nEnter your username: ");

                        Console.ForegroundColor = ConsoleColor.Cyan;
                        string uNameInput = Console.ReadLine();
                        Console.ResetColor();

                        for (int user = 0; user < voiidUser.Count; user++)
                        {
                            if (uNameInput == voiidUser[user].username)
                            {
                                userNum = user;
                                break;
                            }
                            else if (user == voiidUser.Count-1)
                            {
                                if (uNameInput != voiidUser[user].username)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\nError: User Not Found");
                                    Console.ResetColor();
                                }
                            }
                        }
                    }

                    while (userNum < 0 || userNum >= voiidUser.Count)
                    {
                        usernameSelect();
                    }

                    //Uses method in User class to check password for specified user

                    //Password matches
                    if (voiidUser[userNum].checkPassword() == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Access Granted.");
                        Console.ResetColor();
                        Console.Write("Welcome, ");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write(voiidUser[userNum].username);
                        Console.ResetColor();
                        Console.WriteLine(".\n");

                        Console.Write("Press any key to continue");
                        Console.ReadKey();

                        //Clear login screen and display desktop
                        Console.Clear();
                        aboutOS();
                        return;
                    }
                    //Password attempt limit exceeded
                    else
                    {
                        Console.Clear();
                        aboutOS();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("FATAL: You have entered an incorrect password too many times.");
                        Console.WriteLine("Project: VoiidOS terminated due to potential data breach.");
                        Console.ResetColor();
                        Console.Write("\nPress any key to continue");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }
                }
            }

            //Calls the Login method so I can reuse
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
