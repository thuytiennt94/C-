// See https://aka.ms/new-console-template for more information
using System;
class NumberFormat
{
    static void Main(string[] args)
    {
        Console.WriteLine("Currency formatting - {0:C} {1:C4}", 88.8, 888.8);
        Console.WriteLine("Integer fotmatting - {0:D5}", 88 );
        Console.WriteLine("Exponential fotmatting - {0:E}", 888.8);
        Console.WriteLine("Fixed-point fotmatting - {0:F3} ", 888.8888);
        Console.WriteLine("Genetal fotmatting - {0:G} ", 888.8888);
        Console.WriteLine("Number fotmatting - {0:N} ", 8888888.8);
        Console.WriteLine("Hexadecimal fotmatting- {0:X4} ", 88);
    }
}
