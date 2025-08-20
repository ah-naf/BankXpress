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

    static bool ExistUser(string username)
    {
        foreach (User user in users) {
            if (user.username == username)
            {
                return true;
            }
        }
        return false;

    }
    static bool validPassword(string password)
    {
        int len = password.Length;
        return len >= 6;
    }

    static void RegisterUser()
    {
        // TODO: Implement registration logic
        Console.Write("Enter an username: ");
        string u_name = Console.ReadLine();

        if(ExistUser(u_name))
        {
            Console.WriteLine("Opps! The user have already registered.");

            // Extend: logic for navigating to dashboard
            return;
        }
        else
        {
            Console.Write("Enter a password ");
            string pass = Console.ReadLine();

            // Extend: implement logic for password validation
                // password length should be greater than or equal 6 (done)
                // combination of letter and number (optional)
            if(!validPassword(pass))
            {
                Console.WriteLine("Please enter a valid password! Password length should be greater or equal to 6");
                return;
            }


            Console.Write("Provide initial deposite: ");
            double bal = Convert.ToDouble(Console.ReadLine());
            
            // Extend: validate the amount (check whether it is greater than 0
            User user = new User(u_name, pass, bal);
            users.Add(user);
            Console.Write("User Registration COmpleted Successfully.");

        }





    }

    static void LoginUser()
    {
        // TODO: Implement login logic
    }
}
