using System;

namespace homework_2
{
    internal class lab2
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Task 2.1");
                Console.WriteLine("Enter your name:");
                string a = Console.ReadLine();
                Console.WriteLine($"Hello, {a}!");
            }
            {
                Console.WriteLine("Task 2.2");
                Console.WriteLine("Enter the first integer:");
                float a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the second integer:");
                float b = Convert.ToInt32(Console.ReadLine());

                if (b > 0)
                {
                    Console.WriteLine($"Result: {a / b}");
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
            {
                Console.WriteLine("Home task 2.1");
                Console.WriteLine("Enter a letter:");
                char letter = Convert.ToChar(Console.ReadLine());
                if (letter == 'z')
                {
                    Console.WriteLine("You entered the last letter of alphabet");
                }
                else if (letter == 'я')
                {
                    Console.WriteLine("You entered the last letter of alphabet");
                }
                else
                {
                    Console.WriteLine($"Next letter:" + (char)(letter + 1));
                }

            }
            {
                Console.WriteLine("Home task 2.2");
                Console.WriteLine("Enter coefficient a:");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter coefficient b:");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter coefficient c:");
                double c = Convert.ToDouble(Console.ReadLine());
                double D = Math.Pow(b, 2) - 4 * a * c;
                if (D > 0)
                {
                    double x1 = -b + Math.Sqrt(D) / 2 * a;
                    double x2 = -b - Math.Sqrt(D) / 2 * a;
                    Console.WriteLine($"{x1}, {x2}");
                }
                else if (D == 0)
                {
                    double x1 = -b / 2 * a;
                    double x2 = x1;
                    Console.WriteLine($"{x1}, {x2}");
                }
                else
                {
                    Console.WriteLine("The equation has no solutions ");
                }
            }
            Console.WriteLine("(Press any key to continue work)");
            Console.ReadKey();
        }
    }
}
