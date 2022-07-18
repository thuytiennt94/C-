// See https://aka.ms/new-console-template for more information
using System;

namespace BookStore
{
    class Authors
    {
        static void Main(string[] args)
        {
            Array objAuthorID = Array.CreateInstance(typeof(int), 3);
            Array objAuthorNames = Array.CreateInstance(typeof(string), 3);
            Array objAddress = Array.CreateInstance(typeof(string), 3);
            Array objState = Array.CreateInstance(typeof(string), 3);

            string input = "";

            for(int i= 0; i<objAuthorNames.Length; i++)
            {
                Console.Write("Enter the id of author: ");
                input = Console.ReadLine();
                objAuthorID.SetValue(Convert.ToInt32(input), i);

                Console.Write("Enter the name of author: ");
                input = Console.ReadLine();
                objAuthorNames.SetValue(input, i);

                Console.Write("Enter the addess: ");
                input = Console.ReadLine();
                objAddress.SetValue(input, i);

                Console.Write("enter the name of state: ");
                input = Console.ReadLine();
                objState.SetValue(input, i);
                Console.WriteLine();
            }

            Console.WriteLine("\nDetails of the authors : \n");
            Console.WriteLine("author if\tName\t\tAddress\t\tstate");
            for(int i= 0; i<objAuthorNames.GetUpperBound(0); i++)
            {
                Console.Write(objAuthorID.GetValue(i) + "\t\t");
                Console.Write(objAuthorNames.GetValue(i) + "\t\t");
                Console.Write(objAddress.GetValue(i) + "\t\t");
                Console.WriteLine(objState.GetValue(i) + "\t");
            }
            Array.Sort(objAuthorNames);

            Console.WriteLine("\nAuthor names after sorting: \n");
            for (int i= 0; i <= objAuthorNames.GetUpperBound(0); i++)
            {
                Console.WriteLine(objAuthorNames.GetValue(i) + "\t");
            }
        }
    }
}