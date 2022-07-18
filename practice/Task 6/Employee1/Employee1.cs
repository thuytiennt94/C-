// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Text;

namespace Company
{
    class Employee1
    {
        static void Main(string[] args)
        {
            int employeeID;
            string employeeName;
            string designation;
            float taxAmount = 0;
            double salary = 0, netSalary = 0;

            Console.Write("enter the id of an employee:");
            employeeID = Convert.ToInt32(Console.ReadLine());

            Console.Write("enter the name of employee:");
            employeeName = Console.ReadLine();

            Console.Write("enter designation:");
            designation = Console.ReadLine();

            Console.Write("enter salary:");
            salary = Convert.ToDouble(Console.ReadLine());

            if (salary >= 10000)
            {
                taxAmount = (float)(salary * 32.5 / 100);
            }
            else
            {
                taxAmount = (float)(salary * 24.8 / 100);
            }
            netSalary = salary - taxAmount;

            Console.WriteLine("\nEmployee details: ");
            Console.WriteLine("Employee ID: " + employeeID);
            Console.WriteLine("Employee Name: " + employeeName);
            Console.WriteLine("Designation: " + designation);
            Console.WriteLine("Salary: {0} $", salary);
            Console.WriteLine("net salary: {0:F2} $ is rounded off to: {1} $", netSalary, (int)netSalary);

        }
    }
}