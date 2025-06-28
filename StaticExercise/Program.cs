using System;

namespace StaticExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Temperature Conversion ===");

            double fahrenheit = 100;
            double celsius = TempConverter.FahrenheitToCelsius(fahrenheit);
            Console.WriteLine($"{fahrenheit}°F is {celsius:F2}°C");

            double celsiusInput = 37;
            double fahrenheitConverted = TempConverter.CelsiusToFahrenheit(celsiusInput);
            Console.WriteLine($"{celsiusInput}°C is {fahrenheitConverted:F2}°F");
        }
    }
}