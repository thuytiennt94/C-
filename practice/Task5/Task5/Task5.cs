﻿// See https://aka.ms/new-console-template for more information
using System;
class Task5
{
    static void Main(string[] args)
    {
        int k = 10;
        int m = 20;
        int s = k + m;
        bool t = m > k;
        double z = Math.Sqrt(5);
        const double pi = 3.14;
        Console.WriteLine("The sum is: " + s);
        Console.WriteLine("is m > k? " + t);
        Console.WriteLine("The sqrt of 5 : " + z);
        Console.WriteLine("The max value of Int32: " + Int32.MaxValue);

        Console.ReadLine();
    }
}