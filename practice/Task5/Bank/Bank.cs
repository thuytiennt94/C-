﻿// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    class Employee
    {
        static void Main(string[] args)
        {
            //Integer variables to store the employee ID
            int employeeID;
            //string variable to store the employee name and designation
            string employeeName;
            string designation = "";

            //dateTiem variable to store the employee
            DateTime birthDate;

            //character variable to store the employee gender
            char gender;

            //byte variable to store the number of years serverd
            byte yearsServed;

            //Double variable to store bonus, salary, tax amount and net salary
            double bonus = 0, salary = 0, taxAmount = 0, netSalary = 0;

            //Acceoting the details od the employee and validating it using if 
            Console.Write("Enter the ID of employee: ");
            employeeID = Convert.ToInt32(Console.ReadLine());
            if (employeeID > 0)
            {
                Console.Write("Enter the name ò the employee: ");
                employeeName = Console.ReadLine();
                if (employeeName != "" && employeeName.Length < 40)
                {
                    Console.Write("Enter date of birth [MM/DD/YYYY]: ");
                    birthDate = Convert.ToDateTime(Console.ReadLine());
                    int age = (DateTime.Today.Subtract(birthDate).Days / 365);
                    if (age >= 18)
                    {
                        Console.Write("enter gender [M/F]: ");
                        gender = Convert.ToChar(Console.ReadLine());

                        Console.WriteLine("select designation (choose the number): ");
                        Console.WriteLine("1. Manager ]n2.System Analyst \n3.Developer \n4.Accountant");
                        Console.Write("Enter your choice:");
                        int choice = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter the lenure in years: ");
                        yearsServed = Convert.ToByte(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                designation = "Manager";
                                salary = 21346;
                                break;
                            case 2:
                                designation = "Saystem Analyst";
                                salary = 16729;
                                break;
                            case 3:
                                designation = "Developer";
                                salary = 14525;
                                break;
                            case 4:
                                designation = "Accountant";
                                salary = 13215;
                                break;
                        }

                        //calculating bonus based on the number of years served
                        if (yearsServed >= 3)
                        {
                            if (salary > 20000)
                            {
                                bonus = salary * 0.09;
                            }
                            else if (salary > 14000 && salary <= 20000)
                            {
                                bonus = salary * 0.05;
                            }
                            else
                            {
                                bonus = salary * 0.02;
                            }
                        }

                        //calculating tax mount and net salary
                        taxAmount = salary * 33 / 100;
                        netSalary = salary - taxAmount;

                        //displaying the details of employee COnsole.writeline
                        Console.WriteLine("Employee ID: " + employeeID);
                        Console.WriteLine("employee name: " + employeeName);
                        Console.WriteLine("date of birthL " + birthDate);
                        if (gender == 'M')
                            Console.WriteLine("Gender: Male");
                        else
                            Console.WriteLine("Gender: Famale");
                        Console.WriteLine("Designation: " + designation);
                        Console.WriteLine("Tenure : " + yearsServed);
                        Console.WriteLine("Salary: {0} $" + salary);
                        Console.WriteLine("Tax amount: {0} $" + taxAmount);
                        Console.WriteLine("Net salary: {0:F2} $ is rounded off to : {1} $", netSalary, (int)netSalary);
                        Console.WriteLine("Bonus: {0} $", bonus);
                    }
                    else
                    {
                        Console.WriteLine("invalid entry for date of birth");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid entry for employee name");
                }
            }
            else
            {
                Console.WriteLine("invalid entry employee id");
            }
            
        }
    }
}