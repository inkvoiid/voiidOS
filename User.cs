using System;
using System.Collections.Generic;

class User
{
    public string username;
    private string password;
    private bool admin;
    public static List<string> userList = new List<string>();

    public User(string uName, string pword, bool isAdmin)
    {
        username = uName;
        password = pword;
        admin = isAdmin;
    }

    public bool checkPassword()
    {
        for (int tryCount = 2; tryCount >= 0; tryCount--)
        {
            Console.ResetColor();
            Console.Write("Enter your password: ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Black;
            string passwordGuess = Console.ReadLine();
            Console.ResetColor();
            Console.WriteLine();
            if (passwordGuess == password)
            {
                return true;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: Password Incorrect");
                if (tryCount == 1)
                {
                    Console.WriteLine("You have {0} try left\n",tryCount);
                }
                else
                {
                    Console.WriteLine("You have {0} tries left\n",tryCount);
                }
            }
        }
        return false;
    }

    public bool isAdmin()
    {
        if (admin == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void preferences()
    {

    }
}
