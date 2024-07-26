using System;

public class Program
{
    // Define a constant for the conversion factor from inches to centimeters
    const double CENTIMETERS_PER_INCH = 2.54;

    public static void Main()
    {
        // Prompt the user to enter the number of inches
        Console.WriteLine("Enter the number of inches:");
        // Read the user's input from the console
        string input = Console.ReadLine();

        try
        {
            // Attempt to convert the user's input to a double
            double inches = Convert.ToDouble(input);
            // Calculate the equivalent length in centimeters
            double centimeters = inches * CENTIMETERS_PER_INCH;
             // Output the result to the console
            Console.WriteLine($"{inches} inches is {centimeters} centimeters.");
        }
        catch (FormatException)
        {
            // If the input is not a valid number, display an error message
            Console.WriteLine("Please enter a valid number.");
        }
    }
}
// 2024/1/6_SenShoikot_Exercise 2.1.1