using System;

// OOP concept demo in C#
// - Class: blueprint that groups data (fields/properties) and behavior (methods).
// - Encapsulation: keep fields private and expose them via properties/methods.
// - Constructor: special method that runs when we create an object with 'new'.
// - Inheritance & Polymorphism: derived class (Student) reuses and overrides Person behavior.
class Person
{
    private string _name; // encapsulated field

    public int Age { get; private set; } // property with private setter

    // Constructor: same name as class, no return type.
    public Person(string name, int age)
    {
        _name = name;
        Age = age;
    }

    // virtual: lets derived classes change behavior (polymorphism).
    public virtual void Introduce()
    {
        Console.WriteLine($"Hi, I'm {_name}, {Age} years old.");
    }
}

// Inheritance: Student derives from Person and extends it.
class Student : Person
{
    public string School { get; private set; }

    // Constructor chaining: 'base' calls Person's constructor first.
    public Student(string name, int age, string school) : base(name, age)
    {
        School = school;
    }

    // Override changes the behavior of Introduce for Student objects.
    public override void Introduce()
    {
        Console.WriteLine($"Hi, I'm a student at {School} and I'm {Age} years old.");
    }
}

class Program
{
    static int Main(string[] args)
    {
        /*
        Console.WriteLine("Hello, World!");
        Console.WriteLine("DSA");
        Console.ReadLine();
		

        Console.Write("Enter a number: ");
        string? input = Console.ReadLine();  // input can be null

        if (int.TryParse(input, out int number))
        {
            Console.WriteLine("Valid number: " + number);
        }
        else
        {
            Console.WriteLine("Invalid number!");
        }

        Console.ReadLine(); // optional pause

        

        for (int i = 1; i <= 5; i++)
        {
            if (i == 3)
                continue;

            Console.WriteLine(i);
        }

        */

        // OOP usage example: create objects and call their constructors/methods.
        Person p = new Person("Alice", 25);      // calls Person constructor
        Student s = new Student("Bob", 20, "ABC College"); // calls Student + base constructor

        // Polymorphism: although 'p' and 's' are different types, both expose Introduce.
        p.Introduce();
        s.Introduce();

        return 0;
    }
}
