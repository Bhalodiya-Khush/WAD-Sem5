int totalSum = 0;
int i = 0;
while (i < 5)
{
    Console.Write("Enter marks of subject " + (i + 1) + " : ");
    int marks = Convert.ToInt32(Console.ReadLine());
    if (marks >= 0 && marks <= 100)
    {
        totalSum += marks;
        i++;
    }
    else
    {
        Console.WriteLine("Invalid Input marks Range should be between 0 and 100");
    }
}
double percentage = totalSum / 5;
char grade;
if (percentage <= 100 && percentage >= 90)
    grade = 'A';
else if (percentage < 90 && percentage >= 80)
    grade = 'B';
else if (percentage < 80 && percentage >= 70)
    grade = 'C';
else if (percentage < 70 && percentage >= 60)
    grade = 'D';
else if (percentage < 60 && percentage >= 50)
    grade = 'E';
else
    grade = 'F';

Console.WriteLine($"Total Marks : {totalSum}\nPercentage : {percentage}\nGrade : {grade} ");
