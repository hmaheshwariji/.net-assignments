//Program1
//using System;

//class BankAccount
//{
//    private double balance;

//    public double Balance
//    {
//        get { return balance; }
//        private set
//        {
//            if (value > balance)
//                balance = value; // Allow only deposit (increase)
//        }
//    }

//    public void Withdraw(double amount)
//    {
//        if (amount <= balance)
//        {
//            balance -= amount;
//            Console.WriteLine("Withdrawn: " + amount);
//        }
//        else
//        {
//            Console.WriteLine("Insufficient balance.");
//        }
//    }

//    public void ShowBalance()
//    {
//        Console.WriteLine("Current Balance: " + balance);
//    }

//    public void Deposit(double amount)
//    {
//        Balance = balance + amount;
//        Console.WriteLine("Deposited: " + amount);
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        BankAccount acc = new BankAccount();

//        acc.Deposit(1000);
//        acc.ShowBalance();

//        acc.Withdraw(500);
//        acc.ShowBalance();
//    }
//}

//Program 2
//using System;

//class Student
//{
//    private int age;

//    public int Age
//    {
//        get { return age; }
//        set
//        {
//            if (value >= 5 && value <= 25)
//                age = value;
//            else
//            {
//                age = 18;
//                Console.WriteLine("Invalid age! Setting default age to 18.");
//            }
//        }
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Student s1 = new Student();
//        s1.Age = 4;
//        Console.WriteLine("Student 1 Age: " + s1.Age);

//        Student s2 = new Student();
//        s2.Age = 20;
//        Console.WriteLine("Student 2 Age: " + s2.Age);

//        Student s3 = new Student();
//        s3.Age = 30;
//        Console.WriteLine("Student 3 Age: " + s3.Age);
//    }
//}

//Program 3
//using System;

//class Employee
//{
//    private double basicSalary;

//    public void SetBasicSalary(double salary)
//    {
//        basicSalary = salary;
//    }

//    public double TotalSalary
//    {
//        get
//        {
//            return basicSalary + (0.2 * basicSalary);
//        }
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Employee emp = new Employee();
//        emp.SetBasicSalary(30000);

//        Console.WriteLine("Total Salary (with 20% bonus): " + emp.TotalSalary);
//    }
//}

//Program 4
//using System;

//class Product
//{
//    public double Price { get; set; }
//    public double Discount { get; set; }

//    public double CalculateFinalPrice()
//    {
//        return Price - (Price * Discount / 100);
//    }

//    static void Main()
//    {
//        Product product = new Product { Price = 2000, Discount = 10 };
//        double finalPrice = product.CalculateFinalPrice();

//        Console.WriteLine("Final Price: " + finalPrice);
//    }
//}

//Program 5
//using System;

//class Car
//{
//    private int speed;

//    public int Speed
//    {
//        get { return speed; }
//        set
//        {
//            if (value > 180)
//                speed = 180;
//            else
//                speed = value;
//        }
//    }

//    static void Main()
//    {
//        Car car = new Car();
//        car.Speed = 150;
//        car.Speed = 200;
//        Console.WriteLine("Final Speed: " + car.Speed);
//    }
//}

//Program 6
//using System;

//delegate int Operation(int a, int b);

//class Program
//{
//    static int Add(int a, int b)
//    {
//        return a + b;
//    }

//    static int Subtract(int a, int b)
//    {
//        return a - b;
//    }

//    static void Main()
//    {
//        Console.Write("Enter first number: ");
//        int num1 = int.Parse(Console.ReadLine());

//        Console.Write("Enter second number: ");
//        int num2 = int.Parse(Console.ReadLine());

//        Operation opAdd = Add;
//        Operation opSubtract = Subtract;

//        Console.WriteLine("Addition: " + opAdd(num1, num2));
//        Console.WriteLine("Subtraction: " + opSubtract(num1, num2));
//    }
//}

//Program 7
//using System;

//delegate string FormatText(string input);

//class Program
//{
//    static string ToUpperCase(string input)
//    {
//        return input.ToUpper();
//    }

//    static string ToLowerCase(string input)
//    {
//        return input.ToLower();
//    }

//    static void Main()
//    {
//        string text = "Hello World";
//        FormatText formatUpper = ToUpperCase;
//        FormatText formatLower = ToLowerCase;
//        Console.WriteLine(formatUpper(text));
//        Console.WriteLine(formatLower(text));
//    }
//}

//Program 8
//using System;

//delegate void BillingOperation(ref double amount);

//class Program
//{
//    static void ShowTotal(ref double amount)
//    {
//        Console.WriteLine("Original Price: " + amount);
//    }

//    static void ApplyDiscount(ref double amount)
//    {
//        amount = amount - (amount * 10 / 100);
//        Console.WriteLine("After 10% Discount: " + amount);
//    }

//    static void AddTax(ref double amount)
//    {
//        amount = amount + (amount * 18 / 100);
//        Console.WriteLine("After 18% GST: " + amount);
//    }

//    static void FinalBill(ref double amount)
//    {
//        Console.WriteLine("Final Payable Amount: " + amount);
//    }

//    static void Main()
//    {
//        double price = 5000;
//        BillingOperation bill = ShowTotal;
//        bill += ApplyDiscount;
//        bill += AddTax;
//        bill += FinalBill;
//        bill(ref price);
//    }
//}

//Program 9
//using System;

//delegate double ConvertTemperature(double celsius);

//class Program
//{
//    static double CelsiusToFahrenheit(double celsius)
//    {
//        return (celsius * 9 / 5) + 32;
//    }

//    static double CelsiusToKelvin(double celsius)
//    {
//        return celsius + 273.15;
//    }

//    static void Main()
//    {
//        double tempC = 25;
//        ConvertTemperature toFahrenheit = CelsiusToFahrenheit;
//        ConvertTemperature toKelvin = CelsiusToKelvin;
//        Console.WriteLine(toFahrenheit(tempC));
//        Console.WriteLine(toKelvin(tempC));
//    }
//}

//Program 10
using System;

delegate void Notifier(string message);

class Program
{
    static void SendEmail(string message)
    {
        Console.WriteLine("Email: " + message);
    }

    static void SendSMS(string message)
    {
        Console.WriteLine("SMS: " + message);
    }

    static void Main()
    {
        Notifier notify = SendEmail;
        notify += SendSMS;
        notify("Assignment Submitted Successfully");
    }
}









