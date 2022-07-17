// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ValueAndReferenceType2
{
    class testA
    {
        public String name;
    }
    class ValueAndReferenceType2
    {
        static void Main(string[] args)
        {
            int z = 10;
            String str = "hello world!";
            Console.WriteLine("***Tast value type: ");
            Console.WriteLine("The value of z before: " + z);
            changeValue(z);
            Console.WriteLine("The value of z after: " + z);

            Console.WriteLine("***Test reference type: ");
            testA a = new testA();
            a.name = "not changed!";
            Console.WriteLine("The value of str before: " + a.name);
            changeValue2(a);
            Console.WriteLine("The value of str after: " + a.name);

            Console.ReadLine();
        }
        public static void changeValue(int k)
        {
            k = 10;
        }
        public static void changeValue2(testA v)
        {
            v.name = "changed it";
        }
    }
}