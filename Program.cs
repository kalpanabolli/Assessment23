﻿using Ass23MainApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass23MainApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            UserManager userManager = new UserManager();

            // Demonstrate user management module
            //userManager.AddUser("John Doe", "john.doe@example.com");
            //  userManager.AddUser("Jane Smith", "jane.smith@example"); // Invalid email format
            Console.WriteLine("Enter UserName");
            userManager.name = Console.ReadLine();
            Console.WriteLine("Enter Email");
            userManager.email = Console.ReadLine();
            userManager.AddUser(userManager.name, userManager.email);

            Console.ReadLine();
        }
    }
}