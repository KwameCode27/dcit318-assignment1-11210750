using System;

namespace TicketPriceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Movie Ticket Price Calculator!");

            // Get user input
            Console.Write("Please enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            // Determine ticket price
            int ticketPrice;
            if (age <= 12 || age >= 65)
                ticketPrice = 7;
            else
                ticketPrice = 10;

            // Display result
            Console.WriteLine($"Your ticket price is: GHC{ticketPrice}");
        }
    }
}

