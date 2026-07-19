using System;
using System.Collections.Generic;

namespace CE066_LAB2
{
    class Program2
    {
        static void DisplayMenu()
        {
            Console.WriteLine("\n========== Student Management ==========");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Display All Students");
            Console.WriteLine("3. Search Student");
            Console.WriteLine("4. Update Student");
            Console.WriteLine("5. Delete Student");
            Console.WriteLine("0. Exit");
        }

        static void Main(string[] args)
        {
            List<string> students = new List<string>();

            while (true)
            {
                DisplayMenu();

                Console.Write("Enter Your Choice : ");
                string choice = Console.ReadLine();

                int input;

                if (!int.TryParse(choice, out input))
                {
                    Console.WriteLine("Invalid input! Please enter numbers only.");
                    continue;
                }

                switch (input)
                {
                    case 1:
                        Console.Write("Enter Student Name : ");
                        string name = Console.ReadLine();

                        if (string.IsNullOrWhiteSpace(name))
                        {
                            Console.WriteLine("Student name cannot be empty.");
                            break;
                        }

                        name = name.Trim();

                        bool exists = false;
                        foreach (string student in students)
                        {
                            if (student.Equals(name, StringComparison.OrdinalIgnoreCase))
                            {
                                exists = true;
                                break;
                            }
                        }

                        if (exists)
                        {
                            Console.WriteLine("Student already exists.");
                        }
                        else
                        {
                            students.Add(name);
                            Console.WriteLine("Student added successfully.");
                        }
                        break;

                    case 2:

                        if (students.Count == 0)
                        {
                            Console.WriteLine("No student records available.");
                        }
                        else
                        {
                            Console.WriteLine("\nStudent Records:");

                            for (int i = 0; i < students.Count; i++)
                            {
                                Console.WriteLine((i + 1) + ". " + students[i]);
                            }
                        }

                        break;

                    case 3:

                        if (students.Count == 0)
                        {
                            Console.WriteLine("Student list is empty.");
                            break;
                        }

                        Console.Write("Enter Student Name to Search : ");
                        string searchName = Console.ReadLine();

                        if (string.IsNullOrWhiteSpace(searchName))
                        {
                            Console.WriteLine("Invalid student name.");
                            break;
                        }

                        searchName = searchName.Trim();

                        bool found = false;

                        foreach (string student in students)
                        {
                            if (student.Equals(searchName, StringComparison.OrdinalIgnoreCase))
                            {
                                found = true;
                                break;
                            }
                        }

                        if (found)
                            Console.WriteLine("Student Found.");
                        else
                            Console.WriteLine("Student Not Found.");

                        break;

                    case 4:

                        if (students.Count == 0)
                        {
                            Console.WriteLine("Student list is empty.");
                            break;
                        }

                        Console.Write("Enter Student Name to Update : ");
                        string oldName = Console.ReadLine();

                        if (string.IsNullOrWhiteSpace(oldName))
                        {
                            Console.WriteLine("Invalid student name.");
                            break;
                        }

                        oldName = oldName.Trim();

                        int index = -1;

                        for (int i = 0; i < students.Count; i++)
                        {
                            if (students[i].Equals(oldName, StringComparison.OrdinalIgnoreCase))
                            {
                                index = i;
                                break;
                            }
                        }

                        if (index == -1)
                        {
                            Console.WriteLine("Student Not Found.");
                            break;
                        }

                        Console.Write("Enter New Name : ");
                        string newName = Console.ReadLine();

                        if (string.IsNullOrWhiteSpace(newName))
                        {
                            Console.WriteLine("New name cannot be empty.");
                            break;
                        }

                        newName = newName.Trim();

                        bool duplicate = false;

                        foreach (string student in students)
                        {
                            if (student.Equals(newName, StringComparison.OrdinalIgnoreCase))
                            {
                                duplicate = true;
                                break;
                            }
                        }

                        if (duplicate)
                        {
                            Console.WriteLine("Another student with this name already exists.");
                        }
                        else
                        {
                            students[index] = newName;
                            Console.WriteLine("Record Updated Successfully.");
                        }

                        break;

                    case 5:

                        if (students.Count == 0)
                        {
                            Console.WriteLine("Student list is empty.");
                            break;
                        }

                        Console.Write("Enter Student Name to Delete : ");
                        string deleteName = Console.ReadLine();

                        if (string.IsNullOrWhiteSpace(deleteName))
                        {
                            Console.WriteLine("Invalid student name.");
                            break;
                        }

                        deleteName = deleteName.Trim();

                        bool removed = false;

                        for (int i = 0; i < students.Count; i++)
                        {
                            if (students[i].Equals(deleteName, StringComparison.OrdinalIgnoreCase))
                            {
                                students.RemoveAt(i);
                                removed = true;
                                break;
                            }
                        }

                        if (removed)
                            Console.WriteLine("Student Deleted Successfully.");
                        else
                            Console.WriteLine("Student Not Found.");

                        break;

                    case 0:
                        Console.WriteLine("Thank you!");
                        return;

                    default:
                        Console.WriteLine("Please enter a choice between 0 and 5.");
                        break;
                }

                Console.WriteLine("\nPress Enter to continue...");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}