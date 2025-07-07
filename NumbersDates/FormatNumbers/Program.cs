// Application Programming .NET Programming with C# by Abdullahi Tijjani
// Example file for formatting numerical data in .NET

using System;

class Program
{
    static void Main()
    {
        int[] quarters = { 1, 2, 3, 4 };
        int[] sales = { 100000, 150000, 200000, 225000 };
        double[] intlMixPct = { .386, .413, .421, .457 };
        int val1 = 1234;
        decimal val2 = 1234.5678m;

        // TODO: Specifying Numerical formatting
        // General format is {index[,alignment]:[format]}
        // Common types are N (Number), G (General), F (Fixed-point),
        // E (Exponential), D (Decimal), P (Percent), X (Hexadecimal),
        // C (Currency in local format)

        // TODO: Add a number after the format to specify precision
        Console.WriteLine($"{val1:D6}, {val1:N2}, {val1:F1}, {val1:G}");

        // TODO: Formatting with alignment and spacing
        Console.WriteLine("\nSales by Quarter:");
        Console.WriteLine("{0,-10} {1,15} {2,20}", "Quarter", "Sales", "Intl. Sales %");

        for (int i = 0; i < quarters.Length; i++)
        {
            Console.WriteLine("{0,-10} {1,15:C} {2,20:P1}",
                quarters[i],
                sales[i],
                intlMixPct[i]);
        }

        Console.WriteLine("\nInternational Sales Raw Values:");
        Console.WriteLine($"{intlMixPct[0]:F3} {intlMixPct[1]:F3} {intlMixPct[2]:F3} {intlMixPct[3]:F3}");

        // Additional examples for study
        Console.WriteLine("\nOther Formats for val2:");
        Console.WriteLine($"Currency: {val2:C}");
        Console.WriteLine($"Fixed-point (2 dp): {val2:F2}");
        Console.WriteLine($"Exponential: {val2:E}");
    }
}

