using System;

namespace TriangleTypeIdentifier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Triangle Type Identifier!");

            // Get user input
            Console.Write("Please enter the length of the first side: ");
            double side1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please enter the length of the second side: ");
            double side2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please enter the length of the third side: ");
            double side3 = Convert.ToDouble(Console.ReadLine());

            // Determine triangle type
            if (side1 == side2 && side2 == side3)
            {
                Console.WriteLine("The triangle is equilateral.");
            }
            else if (side1 == side2 || side2 == side3 || side1 == side3)
            {
                Console.WriteLine("The triangle is isosceles.");
            }
            else
            {
                Console.WriteLine("The triangle is scalene.");
            }
        }
    }
}