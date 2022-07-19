// See https://aka.ms/new-console-template for more information
using System;
namespace Destructor
{
    class Employee
    {
        private int _empid;
        private String _empName;
        private int _age;
        private double _salary;
        Employee(int id, string name, int age, double sal)
        {
            Console.WriteLine("construstor for emplotee called");
            _empid = id;
            _empName = name;
            _age = age;
            _salary = sal;
        }
        ~Employee()
        {
            Console.WriteLine("Destructor for employee called");
        }
        static void Main(string[] args)
        {
            Employee emp = new Employee(1, "John", 45, 35000);
            Console.WriteLine("Employee ID" + emp._empid);
            Console.WriteLine("Employee Name" + emp._empName);
            Console.WriteLine("Age: " + emp._age);
            Console.WriteLine("Salary: " + emp._salary);
        }
    }
}