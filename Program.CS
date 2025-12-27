using System;

namespace PackageExpress
{
    // This class contains the required void method with two integer parameters
    class MethodClass
    {
        // Void method that performs a math operation on the first integer
        // and displays the second integer
        public void DoOperation(int num1, int num2)
        {
            int result = num1 * 2; // Math operation on first integer
            Console.WriteLine("First number multiplied by 2: " + result);
            Console.WriteLine("Second number is: " + num2);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Display welcome message to the user
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Prompt user for the package weight
            Console.WriteLine("Please enter the package weight:");
            int weight = Convert.ToInt32(Console.ReadLine());

            // Check if weight is greater than 50
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return;
            }

            // Prompt user for the package width
            Console.WriteLine("Please enter the package width:");
            int width = Convert.ToInt32(Console.ReadLine());

            // Prompt user for the package height
            Console.WriteLine("Please enter the package height:");
            int height = Convert.ToInt32(Console.ReadLine());

            // Prompt user for the package length
            Console.WriteLine("Please enter the package length:");
            int length = Convert.ToInt32(Console.ReadLine());

            // Check if total dimensions exceed 50
            if (width + height + length > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return;
            }

            // Calculate shipping quote
            int dimensionsProduct = width * height * length;
            int volumeTimesWeight = dimensionsProduct * weight;
            decimal quote = (decimal)volumeTimesWeight / 100;

            // Display the quote
            Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString("0.00"));
            Console.WriteLine("Thank you!");

            // ------------------------------
            // METHOD CLASS REQUIREMENT BELOW
            // ------------------------------

            // Instantiate the MethodClass
            MethodClass methodObject = new MethodClass();

            // Call the method normally
            methodObject.DoOperation(5, 10);

            // Call the method using named parameters
            methodObject.DoOperation(num1: 7, num2: 14);

            Console.ReadLine();
        }
    }
}
