using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string Username = "admin";
           string Password = "12345";
            int attempts = 3;
           Console.Write("Enter username: ");
           string username = Console.ReadLine();

          Console.Write("Enter password: ");
          string password = Console.ReadLine();
            while (attempts > 0)
            {
                if (username == Username && password == Password)
                {
                    Console.WriteLine("Login successful.");
                    break;
                   
                }
                else if (username == Username)
                {
                    Console.WriteLine("Invalid password.");
                    
                    
                }
                else
                {
                    Console.WriteLine("Invalid username.");
                    
                }
                attempts--;
                Console.WriteLine("Login failed.");
            }
           
            Console.ReadKey();



        }
    }
}
