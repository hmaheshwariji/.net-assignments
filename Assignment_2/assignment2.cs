//Program 1
//using System;

//class UserProfile
//{
//    private string username;
//    private string password;
//    private string email;

//    public void SetUsername(string username)
//    {
//        if (!string.IsNullOrWhiteSpace(username))
//            this.username = username;
//        else
//            Console.WriteLine("Invalid username.");
//    }

//    public string GetUsername()
//    {
//        return username;
//    }

//    public void SetPassword(string password)
//    {
//        if (password.Length >= 6)
//            this.password = password;
//        else
//            Console.WriteLine("Password must be at least 6 characters long.");
//    }

//    public string GetPassword()
//    {
//        return password;
//    }

//    public void SetEmail(string email)
//    {
//        if (email.Contains("@"))
//            this.email = email;
//        else
//            Console.WriteLine("Invalid email address.");
//    }

//    public string GetEmail()
//    {
//        return email;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        UserProfile user1 = new UserProfile();
//        user1.SetUsername("Harsh123");
//        user1.SetPassword("securePass");
//        user1.SetEmail("harsh@example.com");

//        Console.WriteLine("User 1 Profile:");
//        Console.WriteLine("Username: " + user1.GetUsername());
//        Console.WriteLine("Password: " + user1.GetPassword());
//        Console.WriteLine("Email: " + user1.GetEmail());

//        Console.WriteLine();

//        UserProfile user2 = new UserProfile();
//        user2.SetUsername("Ananya");
//        user2.SetPassword("123");  // invalid, too short
//        user2.SetEmail("ananyaexample.com"); // invalid, missing '@'

//        Console.WriteLine("User 2 Profile:");
//        Console.WriteLine("Username: " + user2.GetUsername());
//        Console.WriteLine("Password: " + user2.GetPassword());
//        Console.WriteLine("Email: " + user2.GetEmail());
//    }
//}

//Program 2
//using System;

//class Vehicle
//{
//    public string Make { get; set; }
//    public string Model { get; set; }
//    public int Year { get; set; }

//    public Vehicle(string make, string model, int year)
//    {
//        Make = make;
//        Model = model;
//        Year = year;
//    }

//    public virtual void DisplayDetails()
//    {
//        Console.WriteLine($"Make: {Make}, Model: {Model}, Year: {Year}");
//    }
//}

//class Truck : Vehicle
//{
//    public double LoadCapacity { get; set; } // in tons

//    public Truck(string make, string model, int year, double loadCapacity)
//        : base(make, model, year)
//    {
//        LoadCapacity = loadCapacity;
//    }

//    public override void DisplayDetails()
//    {
//        Console.WriteLine($"[Truck] Make: {Make}, Model: {Model}, Year: {Year}, Load Capacity: {LoadCapacity} tons");
//    }
//}

//class Bus : Vehicle
//{
//    public int SeatingCapacity { get; set; }

//    public Bus(string make, string model, int year, int seatingCapacity)
//        : base(make, model, year)
//    {
//        SeatingCapacity = seatingCapacity;
//    }

//    public override void DisplayDetails()
//    {
//        Console.WriteLine($"[Bus] Make: {Make}, Model: {Model}, Year: {Year}, Seating Capacity: {SeatingCapacity}");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Truck truck1 = new Truck("Tata", "Harrier", 2022, 17.6);
//        Bus bus1 = new Bus("Volvo", "LuxuryCoach", 2022, 50);

//        truck1.DisplayDetails();
//        bus1.DisplayDetails();
//    }
//}

//Program 3
//using System;

//class Calculator
//{
//    public int Add(int a, int b)
//    {
//        return a + b;
//    }

//    public float Add(float a, float b)
//    {
//        return a + b;
//    }

//    public double Add(double a, double b)
//    {
//        return a + b;
//    }

//    public int Add(int a, int b, int c)
//    {
//        return a + b + c;
//    }

//    public double Add(double a, double b, double c)
//    {
//        return a + b + c;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Calculator calc = new Calculator();

//        Console.WriteLine("Addition with two integers: " + calc.Add(7, 14));
//        Console.WriteLine("Addition with two floats: " + calc.Add(4.5f, 3.2f));
//        Console.WriteLine("Addition with two doubles: " + calc.Add(7.8, 2.3));
//        Console.WriteLine("Addition with three integers: " + calc.Add(3, 6, 69));
//        Console.WriteLine("Addition with three doubles: " + calc.Add(1.2, 2.4, 3.6));
//    }
//}

//Program 4
//using System;

//abstract class Employee
//{
//    public string Name { get; set; }
//    public int Id { get; set; }

//    public Employee(string name, int id)
//    {
//        Name = name;
//        Id = id;
//    }

//    public abstract double CalculateSalary();
//}

//class FullTimeEmployee : Employee
//{
//    public double MonthlySalary { get; set; }

//    public FullTimeEmployee(string name, int id, double monthlySalary)
//        : base(name, id)
//    {
//        MonthlySalary = monthlySalary;
//    }

//    public override double CalculateSalary()
//    {
//        return MonthlySalary; // Fixed salary
//    }
//}

//class PartTimeEmployee : Employee
//{
//    public double HourlyRate { get; set; }
//    public int HoursWorked { get; set; }

//    public PartTimeEmployee(string name, int id, double hourlyRate, int hoursWorked)
//        : base(name, id)
//    {
//        HourlyRate = hourlyRate;
//        HoursWorked = hoursWorked;
//    }

//    public override double CalculateSalary()
//    {
//        return HourlyRate * HoursWorked; // Pay based on hours worked
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        FullTimeEmployee emp1 = new FullTimeEmployee("Virat Kohli", 18, 23000);
//        PartTimeEmployee emp2 = new PartTimeEmployee("Ab Devilliers", 17, 700, 60);

//        Console.WriteLine($"Full-Time Employee: {emp1.Name}, Salary: {emp1.CalculateSalary()}");
//        Console.WriteLine($"Part-Time Employee: {emp2.Name}, Salary: {emp2.CalculateSalary()}");
//    }
//}

//Program 5
//using System;

//class Student
//{
//    private string name;
//    private int rollNumber;
//    private double marks;

//    public Student()
//    {
//        name = "Unknown";
//        rollNumber = 0;
//        marks = 0.0;
//    }
//    public Student(string name, int rollNumber)
//    {
//        this.name = name;
//        this.rollNumber = rollNumber;
//        marks = 0.0;
//    }
//    public Student(string name, int rollNumber, double marks)
//    {
//        this.name = name;
//        this.rollNumber = rollNumber;
//        this.marks = marks;
//    }

//    public void Display()
//    {
//        Console.WriteLine($"Name: {name}, Roll Number: {rollNumber}, Marks: {marks}");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Student s1 = new Student();
//        Student s2 = new Student("Harsh", 101);
//        Student s3 = new Student("Ishu", 102, 90.5);

//        Console.WriteLine("Student Records:");
//        s1.Display();
//        s2.Display();
//        s3.Display();
//    }
//}

//Program 6
//using System;

//class Product
//{
//    private double price;
//    private int quantity;

//    public int ProductID { get; set; }
//    public string ProductName { get; set; }

//    public double Price
//    {
//        get { return price; }
//        set
//        {
//            if (value >= 0)
//                price = value;
//            else
//                Console.WriteLine("Invalid price. Must be non-negative.");
//        }
//    }

//    public int Quantity
//    {
//        get { return quantity; }
//        set
//        {
//            if (value >= 0)
//                quantity = value;
//            else
//                Console.WriteLine("Invalid quantity. Must be non-negative.");
//        }
//    }

//    public void DisplayDetails()
//    {
//        Console.WriteLine($"ID: {ProductID}, Name: {ProductName}, Price: {Price}, Quantity: {Quantity}");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Product p1 = new Product();
//        p1.ProductID = 101;
//        p1.ProductName = "Tablet";
//        p1.Price = 20000;
//        p1.Quantity = 15;

//        Product p2 = new Product();
//        p2.ProductID = 102;
//        p2.ProductName = "Keyboard";
//        p2.Price = 500;
//        p2.Quantity = 6;

//        p1.DisplayDetails();
//        p2.DisplayDetails();
//    }
//}

//Program7
//using System;
//using System.Collections.Generic;

//class Book
//{
//    public int BookID { get; set; }
//    public string Title { get; set; }
//    public string Author { get; set; }
//    public bool IsAvailable { get; set; } = true;

//    public Book(int id, string title, string author)
//    {
//        BookID = id;
//        Title = title;
//        Author = author;
//    }

//    public virtual void Display()
//    {
//        Console.WriteLine($"ID: {BookID}, Title: {Title}, Author: {Author}, Available: {IsAvailable}");
//    }
//}

//class Member
//{
//    public int MemberID { get; set; }
//    public string Name { get; set; }
//    public List<Book> BorrowedBooks { get; set; } = new List<Book>();

//    public Member(int id, string name)
//    {
//        MemberID = id;
//        Name = name;
//    }

//    public void BorrowBook(Book book)
//    {
//        if (book.IsAvailable)
//        {
//            BorrowedBooks.Add(book);
//            book.IsAvailable = false;
//            Console.WriteLine($"{Name} borrowed '{book.Title}'.");
//        }
//        else
//        {
//            Console.WriteLine($"Sorry, '{book.Title}' is not available.");
//        }
//    }

//    public void ReturnBook(Book book)
//    {
//        if (BorrowedBooks.Contains(book))
//        {
//            BorrowedBooks.Remove(book);
//            book.IsAvailable = true;
//            Console.WriteLine($"{Name} returned '{book.Title}'.");
//        }
//    }

//    public void DisplayBorrowedBooks()
//    {
//        Console.WriteLine($"{Name}'s Borrowed Books:");
//        if (BorrowedBooks.Count == 0)
//        {
//            Console.WriteLine("None");
//        }
//        else
//        {
//            foreach (var book in BorrowedBooks)
//            {
//                Console.WriteLine(book.Title);
//            }
//        }
//    }
//}

//class Library
//{
//    private List<Book> books = new List<Book>();
//    private List<Member> members = new List<Member>();

//    public void AddBook(Book book)
//    {
//        books.Add(book);
//    }

//    public void RegisterMember(Member member)
//    {
//        members.Add(member);
//    }

//    public void DisplayAvailableBooks()
//    {
//        Console.WriteLine("Available Books:");
//        foreach (var book in books)
//        {
//            if (book.IsAvailable)
//            {
//                book.Display();
//            }
//        }
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Library library = new Library();

//        Book b1 = new Book(101, "C# Basics", "John Smith");
//        Book b2 = new Book(102, "OOP Concepts", "Jane Doe");
//        Book b3 = new Book(103, "Data Structures", "Alice");

//        library.AddBook(b1);
//        library.AddBook(b2);
//        library.AddBook(b3);

//        Member m1 = new Member(1, "Harsh");
//        Member m2 = new Member(2, "Ishu");

//        library.RegisterMember(m1);
//        library.RegisterMember(m2);

//        library.DisplayAvailableBooks();

//        m1.BorrowBook(b1);
//        m2.BorrowBook(b1); 
//        m2.BorrowBook(b2);

//        library.DisplayAvailableBooks();

//        m1.DisplayBorrowedBooks();
//        m2.DisplayBorrowedBooks();

//        m1.ReturnBook(b1);
//        library.DisplayAvailableBooks();
//    }
//}








