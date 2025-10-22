////Program 1
////using System;

////class Employee
////{
////    public string Name { get; set; }
////    public int Age { get; set; }
////    public double Salary { get; set; }

////    public void DisplayDetails()
////    {
////        Console.WriteLine($"Name: {Name}, Age: {Age}, Salary: {Salary}");
////    }
////}

////class Program
////{
////    static void Main()
////    {
////        Employee emp1 = new Employee { Name = "Harsh", Age = 28, Salary = 50000 };
////        Employee emp2 = new Employee { Name = "Ananya", Age = 26, Salary = 45000 };

////        emp1.DisplayDetails();
////        emp2.DisplayDetails();
////    }
////}

//Program 2
//using System;

//class BankAccount
//{
//    public int AccountNumber { get; set; }
//    public string AccountHolderName { get; set; }
//    public double Balance { get; private set; }

//    public BankAccount(int accountNumber, string accountHolderName, double initialBalance)
//    {
//        AccountNumber = accountNumber;
//        AccountHolderName = accountHolderName;
//        Balance = initialBalance;
//    }

//    public void Deposit(double amount)
//    {
//        if (amount > 0)
//        {
//            Balance += amount;
//            Console.WriteLine($"Deposited: {amount}. New Balance: {Balance}");
//        }
//        else
//        {
//            Console.WriteLine("Deposit amount must be positive.");
//        }
//    }

//    public void Withdraw(double amount)
//    {
//        if (amount > 0 && amount <= Balance)
//        {
//            Balance -= amount;
//            Console.WriteLine($"Withdrawn: {amount}. Remaining Balance: {Balance}");
//        }
//        else
//        {
//            Console.WriteLine("Invalid withdrawal amount.");
//        }
//    }

//    public void DisplayAccountDetails()
//    {
//        Console.WriteLine($"Account Number: {AccountNumber}, Name: {AccountHolderName}, Balance: {Balance}");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        BankAccount acc1 = new BankAccount(101, "Harsh", 3000);
//        BankAccount acc2 = new BankAccount(102, "Kartik", 8000);

//        acc1.DisplayAccountDetails();
//        acc1.Deposit(1000);
//        acc1.Withdraw(1500);
//        acc1.DisplayAccountDetails();

//        acc2.DisplayAccountDetails();
//        acc2.Deposit(600);
//        acc2.Withdraw(15000); 
//        acc2.DisplayAccountDetails();
//    }
//}



//Program 3

//using System;

//static class MathHelper
//{
//    public static double CalculateAverage(int[] numbers)
//    {
//        if (numbers.Length == 0)
//            return 0;

//        int sum = 0;
//        for (int i = 0; i < numbers.Length; i++)
//        {
//            sum += numbers[i];
//        }

//        return (double)sum / numbers.Length;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        int[] data = { 10, 20, 30, 40, 50 };
//        double average = MathHelper.CalculateAverage(data);
//        Console.WriteLine("Average: " + average);
//    }
//}

//Program 4
//using System;

//static class Logger
//{
//    public static void LogMessage(string message)
//    {
//        Console.WriteLine($"[{DateTime.Now}] {message}");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Logger.LogMessage("Application started.");
//        Logger.LogMessage("Processing data...");
//        Logger.LogMessage("Application ended.");
//    }
//}

//Program5
//using System;

//public partial class Person
//{
//    public string FirstName { get; set; }
//    public string LastName { get; set; }
//}

//public partial class Person
//{
//    public void PrintFullName()
//    {
//        Console.WriteLine($"Full Name: {FirstName} {LastName}");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Person person1 = new Person();
//        person1.FirstName = "Harsh";
//        person1.LastName = "Maheshwari";
//        person1.PrintFullName();

//        Person person2 = new Person();
//        person2.FirstName = "Khushi ";
//        person2.LastName = "Rathi";
//        person2.PrintFullName();
//    }
//}

//Program 6
//using System;

//public partial class Employee
//{
//    public string Name { get; set; }
//    public int Age { get; set; }
//    public double BasicSalary { get; set; }
//    public double Allowance { get; set; }
//}

//public partial class Employee
//{
//    public double CalculateTotalSalary()
//    {
//        return BasicSalary + Allowance;
//    }

//    public double CalculateSalaryWithBonus(double bonus)
//    {
//        return BasicSalary + Allowance + bonus;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Employee emp1 = new Employee();
//        emp1.Name = "Harsh";
//        emp1.Age = 23;
//        emp1.BasicSalary = 60000;
//        emp1.Allowance = 4000;

//        Employee emp2 = new Employee();
//        emp2.Name = "Kirti";
//        emp2.Age = 22;
//        emp2.BasicSalary = 20000;
//        emp2.Allowance = 5000;

//        Console.WriteLine($"{emp1.Name}'s Total Salary: {emp1.CalculateTotalSalary()}");
//        Console.WriteLine($"{emp1.Name}'s Salary with Bonus 3000: {emp1.CalculateSalaryWithBonus(3000)}");

//        Console.WriteLine($"{emp2.Name}'s Total Salary: {emp2.CalculateTotalSalary()}");
//        Console.WriteLine($"{emp2.Name}'s Salary with Bonus 2000: {emp2.CalculateSalaryWithBonus(2000)}");
//    }
//}

//Program 7
//using System;

//abstract class Shape
//{
//    public abstract double CalculateArea();
//}

//class Circle : Shape
//{
//    public double Radius { get; set; }

//    public Circle(double radius)
//    {
//        Radius = radius;
//    }

//    public override double CalculateArea()
//    {
//        return Math.PI * Radius * Radius;
//    }
//}

//class Rectangle : Shape
//{
//    public double Length { get; set; }
//    public double Width { get; set; }

//    public Rectangle(double length, double width)
//    {
//        Length = length;
//        Width = width;
//    }

//    public override double CalculateArea()
//    {
//        return Length * Width;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Shape circle = new Circle(6);
//        Shape rectangle = new Rectangle(7, 5);

//        Console.WriteLine("Circle Area: " + circle.CalculateArea());
//        Console.WriteLine("Rectangle Area: " + rectangle.CalculateArea());
//    }
//}


//Program 8
//using System;

//abstract class Animal
//{
//    public string Name { get; set; }
//    public int Age { get; set; }

//    public Animal(string name, int age)
//    {
//        Name = name;
//        Age = age;
//    }

//    public abstract void MakeSound();
//}

//class Dog : Animal
//{
//    public Dog(string name, int age) : base(name, age) { }

//    public override void MakeSound()
//    {
//        Console.WriteLine($"{Name} says: Woof!");
//    }

//    public void Fetch()
//    {
//        Console.WriteLine($"{Name} is fetching the ball.");
//    }
//}

//class Cat : Animal
//{
//    public Cat(string name, int age) : base(name, age) { }

//    public override void MakeSound()
//    {
//        Console.WriteLine($"{Name} says: Meow!");
//    }

//    public void Scratch()
//    {
//        Console.WriteLine($"{Name} is scratching the furniture.");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Dog dog = new Dog("Buddy", 3);
//        Cat cat = new Cat("Whiskers", 2);

//        dog.MakeSound();
//        dog.Fetch();

//        cat.MakeSound();
//        cat.Scratch();
//    }
//}


//Program 9
//using System;

//class Vehicle
//{
//    public void StartEngine()
//    {
//        Console.WriteLine("Engine started.");
//    }

//    public void StopEngine()
//    {
//        Console.WriteLine("Engine stopped.");
//    }
//}

//sealed class Car : Vehicle
//{
//    public void Drive()
//    {
//        Console.WriteLine("Car is driving.");
//    }
//}

///*
//class SportsCar : Car
//{
//    public void TurboMode()
//    {
//        Console.WriteLine("Turbo mode activated!");
//    }
//}
//*/

//class Program
//{
//    static void Main()
//    {
//        Car myCar = new Car();
//        myCar.StartEngine();
//        myCar.Drive();
//        myCar.StopEngine();
//    }
//}

//Program 10
//using System;

//class BankAccount
//{
//    public int AccountNumber { get; set; }
//    public double Balance { get; set; }

//    public void Deposit(double amount)
//    {
//        Balance += amount;
//        Console.WriteLine("Deposited: " + amount);
//    }

//    public void Withdraw(double amount)
//    {
//        if (amount <= Balance)
//        {
//            Balance -= amount;
//            Console.WriteLine("Withdrawn: " + amount);
//        }
//        else
//        {
//            Console.WriteLine("Insufficient balance.");
//        }
//    }
//}

//sealed class SavingsAccount : BankAccount
//{
//    public double InterestRate { get; set; }

//    public void CalculateInterest()
//    {
//        double interest = Balance * InterestRate / 100;
//        Balance += interest;
//        Console.WriteLine("Interest added: " + interest);
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        SavingsAccount acc = new SavingsAccount();
//        acc.AccountNumber = 12345;
//        acc.Balance = 10000;
//        acc.InterestRate = 5;

//        acc.Deposit(2000);
//        acc.CalculateInterest();
//        acc.Withdraw(3000);

//        Console.WriteLine("Final Balance: " + acc.Balance);
//    }
//}

