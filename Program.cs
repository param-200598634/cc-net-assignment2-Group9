using System;

namespace Csharp_Assignment2_Group9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1) Concatenate first and last name and print
            PrintFullName("Paramvir", "Singh");

            // 2) Celsius to Fahrenheit
            double celsius = 25.0;
            double fahrenheit = CelsiusToFahrenheit(celsius);
            Console.WriteLine($"{celsius:F2}°C = {fahrenheit:F2}°F");

            // 3) Fahrenheit to Celsius
            double fValue = 212.0;
            double cValue = FahrenheitToCelsius(fValue);
            Console.WriteLine($"{fValue:F2}°F = {cValue:F2}°C");

            // 4) Useful method of choice: Calculate circle area
            double radius = 2.5;
            double area = CalculateCircleArea(radius);
            Console.WriteLine($"Circle radius {radius} => Area = {area:F2}");

            // Keep console open when run without debugging
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        // Method 1: Concatenate first and last name, print full name
        static void PrintFullName(string firstName, string lastName)
        {
            string fullName = firstName + " " + lastName;
            Console.WriteLine("Full name: " + fullName);
        }

        // Method 2: Convert Celsius to Fahrenheit and return double
        static double CelsiusToFahrenheit(double c)
        {
            double f = (c * 9.0 / 5.0) + 32.0;
            return f;
        }

        // Method 3: Convert Fahrenheit to Celsius and return double
        static double FahrenheitToCelsius(double f)
        {
            double c = (f - 32.0) * 5.0 / 9.0;
            return c;
        }

        // Method 4: Useful method - calculate area of a circle
        static double CalculateCircleArea(double radius)
        {
            return Math.PI * radius * radius;
        }
    }
}
