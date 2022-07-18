// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Text;

namespace School
{
    class Student
    {
        static void Main(string[] args)
        {
            string studentName;
            int english, maths, science;
            float percent = 0, amount = 0;
            Console.Write("enter the name of the student: ");
            studentName = Console.ReadLine();

            Console.Write("enter marks in english: ");
            english = Convert.ToInt32(Console.ReadLine());

            Console.Write("enter marks in maths:");
            maths = Convert.ToInt32(Console.ReadLine());

            Console.Write("enter marks in science:");
            science = Convert.ToInt32(Console.ReadLine());

            if ((english >= 0 && english <= 100) && (maths >= 0 && maths <= 100) && (science >= 0 && science <= 100))
            {
                if (english >= 35 && maths >= 35 && science >= 35)
                {
                    percent = ((english + maths + science) * 100) / 300;

                    if (percent > 75)
                        amount = 1500;
                    else if (percent >= 60 && percent <= 75)
                        amount = 1000;
                    else
                        amount = 0;

                    Console.WriteLine("\nStudent Name: " + studentName);
                    Console.WriteLine("Total marks: " + (english + maths + science));
                    Console.WriteLine("Percentage: " + percent + "%");

                    Console.WriteLine("Scholarship amount: " + amount + "%");

                }
                else
                {
                    Console.WriteLine("\nStudent Name: " + studentName);
                    Console.WriteLine("Result: Failed");
                }
            }
            else
            {
                Console.WriteLine("invalid entry of marks");
            }
        }
    }
}