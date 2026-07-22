using System;
using System.Collections.Generic;
using System.Linq;

namespace Program1
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string Department { get; set; }
        public int Sem { get; set; }
        public int Age { get; set; }
        public double CGPA { get; set; }
    }

    public class StudentRecord
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student { StudentId=101, StudentName="Khush", Department="CE", Sem=5, Age=18, CGPA=8.41 },
                new Student { StudentId=102, StudentName="Parva", Department="IT", Sem=5, Age=18, CGPA=7.70 },
                new Student { StudentId=103, StudentName="Om", Department="IT", Sem=5, Age=18, CGPA=9.5 },
                new Student { StudentId=104, StudentName="Yash", Department="CE", Sem=5, Age=18, CGPA=6.70 },
                new Student { StudentId=105, StudentName="Darshan", Department="IT", Sem=5, Age=18, CGPA=7.33 },
                new Student { StudentId=106, StudentName="Ankur", Department="CE", Sem=5, Age=18, CGPA=8.81 },
                new Student { StudentId=107, StudentName="Tirth", Department="CE", Sem=5, Age=18, CGPA=8.30 },
                new Student { StudentId=108, StudentName="Shrey", Department="AI", Sem=5, Age=18, CGPA=8.90 }
            };

            Console.WriteLine("Students with CGPA > 8.0");
            var result1 = students.Where(s => s.CGPA > 8.0);

            foreach (var s in result1)
                Console.WriteLine(s.StudentName);
            

            Console.WriteLine("\nCE Students Sorted by CGPA");
            var result2 = students
                            .Where(s => s.Department == "CE")
                            .OrderByDescending(s => s.CGPA);

            foreach (var s in result2)
                Console.WriteLine(s.StudentName + " - " + s.CGPA);
            

            Console.WriteLine("\nTop 3 Students");
            var result3 = students
                            .OrderByDescending(s => s.CGPA)
                            .Take(3);

            foreach (var s in result3)
                Console.WriteLine(s.StudentName + " - " + s.CGPA);
            

            Console.WriteLine("\nStudent Count in Each Department");
            var result4 = students.GroupBy(s => s.Department);

            foreach (var group in result4)
                Console.WriteLine(group.Key + " : " + group.Count());
            
        }
    }
}