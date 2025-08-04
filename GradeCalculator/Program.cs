using System;

namespace GradeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Grade Calculator!");

            // Get user input
            Console.Write("Enter your name: ");
            string name = Console.ReadLine() ?? string.Empty;

            Console.Write("Enter your grade (0-100): ");
            int grade = Convert.ToInt32(Console.ReadLine());

            // Determine letter grade
            string letterGrade;
            if (grade >= 90)
                letterGrade = "A";
            else if (grade >= 80)
                letterGrade = "B";
            else if (grade >= 70)
                letterGrade = "C";
            else if (grade >= 60)
                letterGrade = "D";
            else
                letterGrade = "F";

            // Display result
            Console.WriteLine($"Student Name: {name}");
            Console.WriteLine($"Grade: {grade}");
            Console.WriteLine($"Letter Grade: {letterGrade}");

            Console.WriteLine("Thank you for using the Grade Calculator!");
        }
    }
}
