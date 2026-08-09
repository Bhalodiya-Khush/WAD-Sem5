using System;

public class Program2
{
    static void Main(string[] args)
    {
        Student s1 = new Student();
        s1.Name = "Khush";
        s1.RollNo = 1;
        s1.Course = "Computer Engineering";

        Student s2 = new Student();
        s2.Name = "Parva";
        s2.RollNo = 2;
        s2.Course = "Information Technology";

        Student s3 = new Student();
        s3.Name = "Yash";
        s3.RollNo = 3;
        s3.Course = "AI/ML";

        Student s4 = new Student();
        s4.Name = "Darshan";
        s4.RollNo = 4;
        s4.Course = "Cyber Security";

        s1.DisplayStudent();
        s2.DisplayStudent();
        s3.DisplayStudent();
        s4.DisplayStudent();
    }
}

public class Student
{
    private string name;
    private int rollNo;
    private string course;

    public string Name
    {
        get { return name; }
        set
        {
            if (value != null)
                name = value;
            else
                Console.WriteLine("Enter Valid Name!!");
        }
    }

    public int RollNo
    {
        get { return rollNo; }
        set
        {
            if (value > 0)
                rollNo = value;
            else
                Console.WriteLine("Enter Valid RollNo.!!");
        }
    }

    public string Course
    {
        get { return course; }
        set
        {
            if (value != null)
                course = value;
            else
                Console.WriteLine("Enter Valid Course!!");
        }
    }

    public void DisplayStudent()
    {
        Console.WriteLine("Name : " + name);
        Console.WriteLine("Roll No : " + rollNo);
        Console.WriteLine("Course : " + course);
        Console.WriteLine();
    }
}