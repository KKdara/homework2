using System;

namespace lab3
{
    enum BankAccount
    {
        Current,
        Savings
    }
    struct Bank
    {
        public long number;
        public string type;
        public float balance;
        public void Print()
        {
            Console.WriteLine($"Your account number: {number} \nYour account type: {type} \nYour balance: {balance}$");
        }
    }
    enum University
    {
        KFU,
        KAI,
        KHTI
    }
    struct employee
    {
        public string name;
        public string university;
        public void Print()
        {
            Console.WriteLine($"Employee's name: {name} \nPlace of work: {university}");
        }
    }
    internal class lab3
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Task 3.1");
                BankAccount account = BankAccount.Current;
                Console.WriteLine($"The type of your bank account: {account}");
            }
            {
                Console.WriteLine("Task 3.2");
                Bank bank = new Bank();
                bank.number = 2200418373497070;
                bank.type = "Current";
                bank.balance = 15650;
                bank.Print();
            }
            {
                Console.WriteLine("Homework 3.1");
                employee employee = new employee();
                University university = University.KFU;
                employee.name = "Ivan";
                employee.university = Convert.ToString(university);
                employee.Print();
            }
            Console.WriteLine("(Press any key to continue work)");
            Console.ReadKey();
        }
    }
}
