using System;

public class Program
{
    const double CENTIMETERS_PER_INCH = 2.54;

    public static void Main()
    {
        Console.WriteLine("Enter the number of inches:");
        string input = Console.ReadLine();

        try
        {
            double inches = Convert.ToDouble(input);
            double centimeters = inches * CENTIMETERS_PER_INCH;
            Console.WriteLine($"{inches} inches is {centimeters} centimeters.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Please enter a valid number.");
        }
    }
}
// 2024/1/6_SenShoikot_Exercise 2.1.1