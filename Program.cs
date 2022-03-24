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
            Console.Clear();
            const double pi = 3.14159265359;
            Console.Write("Please input the radius of the circle: ");
            int radius = int.Parse(Console.ReadLine());
            double area = pi * (radius * radius);
            Console.WriteLine(value: $"Area of a circle with radius " + radius + " is - " + area + "\n\n");
            Console.WriteLine("Press any key to continue..");
            Console.ReadKey();
        }

        static void StringActivity()
        {
            Console.Clear();
            const string myName = "Tony Hart";
            Console.WriteLine($"My name is {myName}");
            Console.Write("Write something funny: ");
            string extra = Console.ReadLine();
            Console.WriteLine(value: $"Length of myName is {myName.Length}");
            extra = myName + " " + extra;
            Console.WriteLine(value: $"You think it's funny to say '{extra}'? Yeah well you're a turd.");
            Console.WriteLine("Press any key to continue..");
            Console.ReadKey();
        }

        static void PasswordChecker()
        {
            Console.Clear();
            Console.WriteLine("Password Checker");
            Console.WriteLine("Enter your password. It must contain at least 8 characters and the character a.");
            String name = Console.ReadLine();  // read a string (password) from the screen
            Console.WriteLine("The length of your password is: " + name.Length);
            Console.WriteLine("Your password contains the letter a: " + name.Contains('a'));
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Program.Main();
        }

        static void Temperature()
            {
                Console.Clear();
                Console.Write("Please input a temperature: ");
                double temp1 = double.Parse(Console.ReadLine());
                Console.Write("(1) to conver to farenheight (2) to convert to celsius: ");
                int select = int.Parse(Console.ReadLine());
                if (select == 1)
                {
                    double farenheight = temp1 * (9.0 / 5.0) + 32;
                    Console.WriteLine("Farenheight temp  is " + farenheight);
                }
                else if (select == 2)
                {
                    double celsius = temp1 - 32 * (9.0/5.0);
                    Console.WriteLine("Celsius temp  is " + celsius);
                }
                else
                {
                    return;
                }
            }

        static void AgePredict()
            {
                Console.Clear();
                Console.Write("Please input your age: ");
                int age = int.Parse(Console.ReadLine());
                Console.Write("Enter a year to find out your age: ");
                int userYear = int.Parse(Console.ReadLine());
                int present = DateTime.Now.Year;
                age = age + (userYear - present);
                Console.WriteLine(value: $"In the year {userYear} you will be {age}");
            }

        static void Calculator()
            {
                Console.Clear();
                int cont = 1;
                int firstNum;
                int secondNum;
                int calc;
                int sum = 0;
                while (cont > 0)
                {
                    if (cont == 2)
                    {
                        Console.Write("0) for main menu, 1) add, 2) subtract, 3) multiply, 4) divide, 5) to find a remainder: ");
                        calc = int.Parse(Console.ReadLine());
                        if (calc == 0)
                        { 
                            cont = 0; 
                        }
                        Console.Write("Please enter a number to perform the operation on your previous sum and press enter: ");
                        secondNum = int.Parse(Console.ReadLine());   // read second number
                        firstNum = sum;
                    }
                    else
                    {
                        Console.Write("0) for main menu, 1) add, 2) subtract, 3) multiply, 4) divide, 5) to find a remainder: ");
                        calc = int.Parse(Console.ReadLine()); // read action to perform
                        if (calc == 0)
                        { 
                            cont = 0; 
                        }
                        Console.Write("Please type the first number and press enter: ");
                        firstNum = int.Parse(Console.ReadLine());   // read first number
                        Console.Write("Please type the second number and press enter: ");
                        secondNum = int.Parse(Console.ReadLine());   // read second number
                        cont = 1;
                    }
                    

                    if (calc == 1)
                    {
                        sum = firstNum + secondNum;
                        Console.WriteLine("The sum of the two numbers is: " +sum);
                        System.Threading.Thread.Sleep(1500);
                    }
                    else if (calc == 2)
                    {
                        sum = firstNum - secondNum;
                        Console.WriteLine(value: $"{firstNum} minus {secondNum} is: " + sum);
                        System.Threading.Thread.Sleep(1500);
                    }
                    else if (calc == 3)
                    {
                        sum = firstNum * secondNum;
                        Console.WriteLine(value: $"{firstNum} multiplied by {secondNum} is: " + sum);
                        System.Threading.Thread.Sleep(1500);
                    }
                    else if (calc == 4)
                    {
                        sum = firstNum / secondNum;
                        Console.WriteLine(value: $"{firstNum} divided by {secondNum} is: " + sum);
                        System.Threading.Thread.Sleep(1500);
                    }
                    else if (calc == 5)
                    {
                        sum = firstNum % secondNum;
                        Console.WriteLine(value: $"Remainder of {firstNum} divided by {secondNum} is: " + sum);
                        System.Threading.Thread.Sleep(1500);
                    }
                }
            }

        static void FortuneTeller()
        {
            Console.Clear();
            string[] careers = {"doctor", "prostitute/gigolo", "retail staff", "manager", "drug dealer", "IT professional", "taxi driver", "cult leader", "professional student", "beggar", "entrepreneur", "dog walker", "camgirl/guy"};
            Console.Write("What is your name? ");
            string uName = Console.ReadLine();
            Console.Write("How old are you? ");
            int uAge = int.Parse(Console.ReadLine());
            Console.Write("What is your bank account balance? ");
            int uMoneys = int.Parse(Console.ReadLine());
            Console.Write("Are you happy? ");
            string answer = Console.ReadLine();
            Random rnd = new Random(); // Assigns System.Rand to variable to generate random numbers later
            uMoneys = uMoneys + rnd.Next(0,(uMoneys*50));
            int uDeath = rnd.Next(uAge, 90);
            int deathYear = DateTime.Now.Year + uDeath;
            int num = rnd.Next(1,uMoneys);
            Console.WriteLine(value: $"You will have {uMoneys} dollars");
            Console.WriteLine(value: $"You wll die in {deathYear} at age {uDeath}");
            int index = rnd.Next(careers.Length);
            Console.WriteLine(value: $"Your primary career will be {careers[index]}");
            if ((num % 3) == 0)
            {
                Console.WriteLine("You will die fulfilled.");
            }
            else
            {
                Console.WriteLine(value: $"You will die unfulfilled with {num%3} tasks considered unfinished.");
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        static void WhereDoYouLive()
        {
            Console.Write("Which city do you live in? ");
            string city = Console.ReadLine();
            switch (city)
                {
                case "Auckland":
                    {
                    Console.WriteLine("You live in the biggest city in NZ!");
                    System.Threading.Thread.Sleep(2500);
                    break;
                    }
                case "Hamilton":
                    {
                        Console.WriteLine("Congratulations for your entry into poo towns of NZ!!");
                        System.Threading.Thread.Sleep(2500);
                        break;
                    }
                case "Christchurch":
                    {
                        Console.WriteLine("Congratulations on being the most racist city in NZ!!");
                        System.Threading.Thread.Sleep(2500);
                        break;
                    }    
                default:
                    {
                        Console.WriteLine("I've heard it's lovely there :) ");
                        System.Threading.Thread.Sleep(2500);
                        break;
                    }
               }
        }

        static void Main()
        {
            bool runTime = true;
            Console.WriteLine("Welcome to the Activities of BIT502 FUNdamentals of Programming.");
            // Main loop - exits when user enters 0
            while (runTime == true)
            {
                Console.Clear();
                Console.WriteLine("0) to Exit");
                Console.WriteLine("1) to calculate the area of a circle");
                Console.WriteLine("2) to play with strings");
                Console.WriteLine("3) to check passwords (read: play with strings more)");
                Console.WriteLine("4) to convert temperatures");
                Console.WriteLine("5) to predict future ages");
                Console.WriteLine("6) to use the calculator");
                Console.WriteLine("7) to have your fortune told");
                Console.WriteLine("8) to for where do you live (case statements)");
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
                else if (opt == 4)
                {
                    Temperature();
                }
                else if (opt == 5)
                {
                    AgePredict();
                }
                else if (opt == 6)
                {
                    Calculator();
                }
                else if (opt == 7)
                {
                    FortuneTeller();
                }
                else if (opt == 8)
                {
                    WhereDoYouLive();
                }
                else
                {
                    if (opt != 0)
                    {
                        Console.Write("That selection is invalid, please try again: ");
                        opt = int.Parse(Console.ReadLine());
                    }
                    else
                    {
                        runTime = false;
                    }
                }
            }
        }
    }
}
// Added FortuneTeller()