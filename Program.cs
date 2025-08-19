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
                LoginUser();
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

    static void LoginUser()
    {
        // TODO: Implement login logic
    }
}
