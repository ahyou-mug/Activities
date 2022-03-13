using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bIT502Activities
{
    public class Program
    {
        static void CircleArea()
        {
            const double pi = 3.14159265359;
            Console.Write("Please input the radius of the circle: ");
            int radius = int.Parse(Console.ReadLine());
            double area = pi * (radius * radius);
            Console.WriteLine(value: $"Area of a circle with radius " + radius + " is - " + area + "\n\n");
            Console.WriteLine("Press any key to continue..");
            Console.ReadKey();
            Program.Main();
        }

        static void StringActivity()
        {
            const string myName = "Tony Hart";
            Console.WriteLine($"My name is {myName}");
            Console.Write("Write something funny: ");
            string extra = Console.ReadLine();
            Console.WriteLine(value: $"Length of myName is {myName.Length}");
            extra = myName + " " + extra;
            Console.WriteLine(value: $"You think it's funny to say '{extra}'? Yeah well you're a turd.");
            Console.WriteLine("Press any key to continue..");
            Console.ReadKey();
            Program.Main();
        }

        static void PasswordChecker()
        {
            Console.WriteLine("Password Checker");
            Console.WriteLine("Enter your password. It must contain at least 8 characters and the character a.");
            String name = Console.ReadLine();  // read a string (password) from the screen
            Console.WriteLine("The length of your password is: " + name.Length);
            Console.WriteLine("Your password contains the letter a: " + name.Contains('a'));
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Program.Main();
        }

        static void Main()
        {
            bool runTime = true;
            Console.WriteLine("Welcome to the Activities of BIT502 FUNdamentals of Programming.");
            // Main loop - exits when user enters 0
            while (runTime == true)
            {
                Console.WriteLine("0) to Exit");
                Console.WriteLine("1) to calculate the area of a circle");
                Console.WriteLine("2) to play with strings");
                Console.WriteLine("3) to check passwords (read: play with strings more)");
                int opt = int.Parse(Console.ReadLine());
                if (opt == 0)
                {
                    runTime = false;
                }
                if (opt == 1)
                {
                    CircleArea();
                }
                else if (opt == 2)
                {
                    StringActivity();
                }
                else if (opt == 3)
                {
                    PasswordChecker();
                }
                else
                {
                    if (opt == 0)
                    {
                        runTime = false;
                    }
                    else
                    {
                        Console.Write("That selection is invalid, please try again: ");
                        opt = int.Parse(Console.ReadLine());
                    }
                }
            }
        }
    }
}
// Added password activity
// sorted boolean logic
// improved exit function