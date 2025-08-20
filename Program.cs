using System;
using System.Collections.Generic;

class User
{
    public string username;
    public string password;
    public double balance;

    public User(string u, string p, double b)
    {
        username = u;
        password = p;
        balance = b;
        // This is a comment
    }
}

class Program
{
    static List<User> users = new List<User>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Welcome to the Banking App!");
            Console.WriteLine("1. Register");
            Console.WriteLine("2. Login");
            Console.WriteLine("3. Exit");
            Console.Write("Select an option: ");
            string option = Console.ReadLine();

            if (option == "1")
            {
                RegisterUser();
            }
            else if (option == "2")
            {
                if(!LoginUser())
                {
                    continue;
                }
                HandleUserOperations();
            }
            else if (option == "3")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid option. Try again.\n");
            }
        }
    }

    static void RegisterUser()
    {
        // TODO: Implement registration logic
    }

    static void HandleUserOperations()
    {
        // TODO: Implemet User operations
    }

    static bool LoginUser()
    {
        Console.Write("Enter Username: ");
        string username = Console.ReadLine();

        User loggedInUser = null;
        foreach (User user in users)
        {
            if (user.username == username)
            {
                loggedInUser = user;
                break;
            }
        }

        if(loggedInUser == null)
        {
            Console.WriteLine("Username not found.");
            return false;
        }

        Console.Write("Enter password: ");
        string password = Console.ReadLine();

        if (loggedInUser.password == password)
        {
            Console.WriteLine($"Login successful! Welcome, {username}.\n");
            return true;
        } else
        {
            Console.WriteLine("Incorrect Password");
            return false;
        }
    }
}
