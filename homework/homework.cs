using System;
using System.Threading;

namespace homework
{
       
    struct user
    {
        public string name;
        public string town;
        public int age;
        public int pin_code;
        public void Print()
        {
            Console.WriteLine($"Name: {name} \nTown: {town} \nAge: {age} \nPIN-code: {pin_code}");
        }

    }
    struct price
    {
        public int normPrice;
        public int salePrice;
        public int holidayPrice;
        public void Print()
        {
            Console.WriteLine($"Average price: {normPrice} \nDiscount: {salePrice}% \nHoliday price: {holidayPrice}");
        }
    }
    struct student
    {
        public string name;
        public string surname;
        public int ID;
        public DateTime birthday;
        public char category;
        public double amount_alcohol;
        public void Print()
        {
            Console.WriteLine($"\nName: {name} \nSurname: {surname} \nId: {ID} \nBirthday: {birthday} \nCategory: {category} \nAmount of alcohol on liters: {amount_alcohol}");
        }
    }
    internal class homework

    {
        static void Main(string[] args)
        {
            {
                
                Console.WriteLine("\nTask 2");
                user user1 = new user();
                Console.WriteLine("Enter your name:");
                user1.name = Console.ReadLine();
                Console.WriteLine("Enter your town:");
                user1.town = Console.ReadLine();
                Console.WriteLine("Enter your age:");
                user1.age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter your PIN-code:");
                user1.pin_code = Convert.ToInt32(Console.ReadLine());
                user1.Print();
            }
            {
                Console.WriteLine("\nTask 4");
                Console.WriteLine("Enter a string:");
                string a = Console.ReadLine();
                Console.WriteLine("Enter a substring:");
                string b = Console.ReadLine();
                string d = a.Replace(b, "");
                int c = (a.Length - d.Length) / b.Length;
                Console.WriteLine($"Amount of substrings: {c}");
            }
            {
                Console.WriteLine("\nTask 5");
                price price = new price();
                Console.WriteLine("Enter standard price:");
                price.normPrice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter discount in %:");
                price.salePrice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter holiday price:");
                price.holidayPrice = Convert.ToInt32(Console.ReadLine());
                double dutyfreePrice = (price.normPrice * (100 - price.salePrice)) / 100;
                double save = price.normPrice - dutyfreePrice;
                double bottles = price.holidayPrice / save;
                Console.WriteLine("Amount of bottles to buy:" + Math.Floor(bottles));
                Console.ReadKey();
            }
            {
                Console.WriteLine("Task 6. The dialog between Harry Potter(User) and Tom Riddle(Console)");
                Console.WriteLine("(Enter greeting)");
                string greeting = Console.ReadLine();
                Console.WriteLine("Hello! What's your name? \n(Enter your name)");
                string name = Console.ReadLine();
                string question = Console.ReadLine();
                Console.WriteLine("Yes.");
                string question1 = Console.ReadLine();
                Console.WriteLine("No.");
                Thread.Sleep(5000);

                Console.WriteLine("But I can show you.");
            }
            {
                Console.WriteLine("\nTask 8");

                student student1 = new student();
                student1.name = "Снежана";
                student1.surname = "Булочкина";
                student1.ID = 1212;
                student1.birthday = new DateTime(2001, 4, 15);
                student1.category = 'a';
                student1.amount_alcohol = 5;
                student1.Print();

                student student2 = new student();
                student2.name = "Алёна";
                student2.surname = "Курова";
                student2.ID = 1313;
                student2.birthday = new DateTime(2000, 5, 17);
                student2.category = 'b';
                student2.amount_alcohol = 2;
                student2.Print();

                student student3 = new student();
                student3.name = "Олег";
                student3.surname = "Пушкин";
                student3.ID = 1414;
                student3.birthday = new DateTime(2005, 2, 13);
                student3.category = 'a';
                student3.amount_alcohol = 1.5;
                student3.Print();

                student student4 = new student();
                student4.name = "Василий";
                student4.surname = "Васильев";
                student4.ID = 1212;
                student4.birthday = new DateTime(1997, 6, 1);
                student4.category = 'c';
                student4.amount_alcohol = 1;
                student4.Print();

                student student5 = new student();
                student5.name = "Степан";
                student5.surname = "Белкин";
                student5.ID = 1616;
                student5.birthday = new DateTime(1999, 10, 15);
                student5.category = 'd';
                student5.amount_alcohol = 0;
                student5.Print();

                double sum = student1.amount_alcohol + student2.amount_alcohol + student3.amount_alcohol + student4.amount_alcohol + student5.amount_alcohol;
                Console.WriteLine($"\nAmount of alcohol: {sum} liters");
                double part1 = (student1.amount_alcohol) * 100 / sum;
                double part2 = (student2.amount_alcohol) * 100 / sum;
                double part3 = (student3.amount_alcohol) * 100 / sum;
                double part4 = (student4.amount_alcohol) * 100 / sum;
                double part5 = (student5.amount_alcohol) * 100 / sum;
                Console.WriteLine($"\nThe first student %: {part1} \nThe second student %: {part2} \nThe third student %: {part3} \nThe fourth student %: {part4} \nThe fifth student %: {part5}");
            }
            Console.WriteLine("(Press any key to continue work)");
            Console.ReadKey();
        }
    }
}
