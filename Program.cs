// See https://aka.ms/new-console-template for more information
using System;
namespace Assignment3_PS1
{
    internal class Program
    {
        static void Main()
        {
            //convert a string to an integer Using TryParse
            Console.WriteLine("convert a string to an integer Using TryParse");
            Console.Write("Enter an integer: ");
            string intStr = Console.ReadLine();
            if (int.TryParse(intStr, out int number))
            {
                Console.WriteLine($"Successfully parsed as an integer: {number}");
            }
            else
            {
                Console.WriteLine($"Failed to parse as an integer. Invalid input: {intStr}");
            }

            // Example 2: Convert for Double
            Console.WriteLine("\nExample 2: Convert for Double");
            Console.Write("Enter a double: ");
            string doubleStr = Console.ReadLine();
            try
            {
                double doubleValue = Convert.ToDouble(doubleStr);
                Console.WriteLine($"Successfully converted to a double: {doubleValue}");
            }
            catch (FormatException)
            {
                Console.WriteLine($"Failed to convert to a double. Invalid format: {doubleStr}");
            }
            catch (OverflowException)
            {
                Console.WriteLine($"Failed to convert to a double. Overflow occurred: {doubleStr}");
            }

            // Example 3: Parse for Decimal
            Console.WriteLine("\nExample 3: Parse for Decimal");
            Console.Write("Enter a decimal: ");
            string decimalStr = Console.ReadLine();
            try
            {
                decimal decimalValue = decimal.Parse(decimalStr);
                Console.WriteLine($"Successfully parsed as a decimal: {decimalValue}");
            }
            catch (FormatException)
            {
                Console.WriteLine($"Failed to parse as a decimal. Invalid format: {decimalStr}");
            }
            catch (OverflowException)
            {
                Console.WriteLine($"Failed to parse as a decimal. Overflow occurred: {decimalStr}");
            }
        }
    }
}
