// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolValue
{
    class TestB
    {
        public String name;
        public String class1;
    }
    class student
    {
        static void Main(string[] args)
        {
            int x = 9;
            String str = "WWW";
            Console.WriteLine("Test values type:");
            Console.WriteLine("The value of x before:" + x);
            changeValue(x);
            Console.WriteLine("The value of x after :" + x);
                
            Console.WriteLine("Test value type: ");
            TestB b = new TestB();
            b.name = "HTMl";
            b.class1 = "A3";
            Console.WriteLine("The value of str before : " + b.name + " \nclass: " + b.class1);
            changeValue2(b);
            Console.WriteLine("The value of str after:" + b.name + " \nclass: " + b.class1);
            Console.ReadLine();
        }
        public static void changeValue(int y)
        {
            y = 6;
        }
        public static void changeValue2(TestB k)
        {
            k.name = "CSS";
            k.class1 = "A7";
        }
    }
}