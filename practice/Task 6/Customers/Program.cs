// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    class Customers
    {
        static void Main(string[] args)
        {
            string[] customerName = new string[3];
            string[] city = new string[3];

            int[] age = new int[3];

            char[] gender = new char[3];

            string cityName;

            int total = 0;

            int i = 0;
            do
            {
                Console.Write("Enter the name of customer: ");
                customerName[i] = Console.ReadLine();
                Console.Write("Enter the age: ");
                age[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Gender [M/F]: ");
                gender[i] = Convert.ToChar(Console.ReadLine());
                Console.Write("Enter city: ");
                city[i] = Console.ReadLine();
                Console.WriteLine();
                i++;

            } while (i < customerName.Length);


        }
    }
}