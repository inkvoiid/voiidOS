using System;
using System.Collections.Generic;

class User
{
    public string username;
    private string password;
    private bool admin;

    public User(string uName, string pword, bool isAdmin)
    {
        username = uName;
        password = pword;
        admin = isAdmin;
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
