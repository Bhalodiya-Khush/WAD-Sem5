using System;
using System.Xml.Linq;

public class Person
{
    protected String name;
    protected int age;

    public String Name
    {
        get { return name; }
        set
        {
            if (name != "")
                name = value;
            else
            {
                name = "";
                Console.WriteLine("Enter Valid Name");
            }
        }
    }
    public int Age
    {
        get { return age; }
        set
        {
            if (age >= 0)
                age = value;
            else
            {
                age = 0;
                Console.WriteLine("Enter Valid age");
            }
        }
    }
    public void DisplayInfo()
    {
        Console.WriteLine("Name : " + name);
        Console.WriteLine("Age : " + age + "\n");
    }
}

public class Teacher : Person
{
    protected String subject;
    protected int salary;

    public String Subject
    {
        get { return subject; }
        set
        {
            if (subject != "")
                subject = value;
            else
            {
                subject = "";
                Console.WriteLine("Enter Valid Subject");
            }
        }
    }

    public int Salary
    {
        get { return salary; }
        set
        {
            if (salary >= 0)
                salary = value;
            else
            {
                salary = 0;
                Console.WriteLine("Enter valid salary");
            }
        }
    }
    public void DisplayInfo()
    {
        Console.WriteLine("Name : " + name);
        Console.WriteLine("Age : " + age);
        Console.WriteLine("Subject : " + subject);
        Console.WriteLine("Salary : " + salary + "\n");
    }
}

public class Program3
{
    static void Main(string[] args)
    {
        Teacher t1 = new Teacher();
        Teacher t2 = new Teacher();

        t1.Name = "Harish";
        t1.Age = 29;
        t1.Subject = "AI/ML";
        t1.Salary = 150000;

        t2.Name = "JHB";
        t2.Age = 35;
        t2.Subject = "WAD";
        t2.Salary = 175000;

        t1.DisplayInfo();
        t2.DisplayInfo();
    }
}
