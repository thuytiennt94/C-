﻿// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace OutputFormat
{
    class OutputFormat
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Currency formatting - {0:C}  {1:C4}", 88.8, 888.8);
            Console.WriteLine("Integer formatting - {0:D5}", 88);

        DateTime dt = DateTime.Now;
        //obtain current time
        Console.WriteLine("Today d format - {0:d}", dt );
        Console.WriteLine("Today d format - {0:d}", dt );
            Console.ReadLine();
        }
    }
}