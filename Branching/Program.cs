using System;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            // Requirement: The first line of the program must be the welcome message.
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Prompt the user for the package weight.
            Console.WriteLine("Please enter the package weight:");
            double weight = Convert.ToDouble(Console.ReadLine());

            // Requirement: If the weight is greater than 50, display an error and end the program.
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return; // Ends the program execution
            }

            // Prompt the user for the package width.
            Console.WriteLine("Please enter the package width:");
            double width = Convert.ToDouble(Console.ReadLine());

            // Prompt the user for the package height.
            Console.WriteLine("Please enter the package height:");
            double height = Convert.ToDouble(Console.ReadLine());

            // Prompt the user for the package length.
            Console.WriteLine("Please enter the package length:");
            double length = Convert.ToDouble(Console.ReadLine());

            // Requirement: If the dimensions total greater than 50, display an error and end the program.
            double totalDimensions = width + height + length;
            if (totalDimensions > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return; // Ends the program execution
            }

            // Calculation: 
            // 1. Multiply the three dimensions (height, width, & length) together.
            // 2. Multiply the product by the weight.
            // 3. Divide the outcome by 100.
            double quote = (width * height * length * weight) / 100;

            // Display the quote to the user formatted as a currency (dollar amount).
            Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");
            Console.WriteLine("Thank you!");
        }
    }
}
