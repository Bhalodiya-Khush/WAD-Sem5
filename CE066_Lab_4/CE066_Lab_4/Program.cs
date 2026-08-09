using System;

public class Program
{
    static void Main(string[] args)
    {
        Student s1 = new Student();
        s1.name = "Khush";
        s1.rollNo = 1;
        s1.course = "Comuper Engineering";
        Student s2 = new Student();
        s2.name = "Parva";
        s2.rollNo = 2;
        s2.course = "Information Technology";
        Student s3 = new Student();
        s3.name = "Yash";
        s3.rollNo = 3;
        s3.course = "AI/ML";
        Student s4 = new Student();
        s4.name = "Darshan";
        s4.rollNo = 4;
        s4.course = "Cyber Security";

        s1.DisplayStudent();
        s2.DisplayStudent();
        s3.DisplayStudent();
        s4.DisplayStudent();
    }
}
public class Student
{
    public String name { get; set; }
    public int rollNo { get; set; }
    public String course { get; set; }

    public void DisplayStudent()
    {
        Console.WriteLine("Name : " + name);
        Console.WriteLine("Roll No : " + rollNo);
        Console.WriteLine("Course : " + course + "\n");
    }
}
