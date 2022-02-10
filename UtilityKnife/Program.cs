using System;
using UtilitiyKnife.Converters;

namespace UtilityKnife
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var converter = new FahrenheitToCelsius();
            var celsius = converter.FahrenheitToCelsiusConverter(212.0);
            Console.WriteLine($"Fahrenheit temperature of 212 is {celsius}.");
        }
    }
}
