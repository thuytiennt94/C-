// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore
{
    class Books
    {
        static void Main(string[] args)
        { 
            string[] bookTitle = new string[6];

            for (int i = 0; i < bookTitle.Length; i++)
            {
                Console.Write("enter the title of book: ");
                bookTitle[i] = Console.ReadLine();
                Console.WriteLine();
            }
            Console.WriteLine("List of Books :");
            foreach (string title in bookTitle)
            {
                Console.WriteLine(title);
            }
            bookTitle[3] = "planet of the apes";
            Console.WriteLine("newly changed title of book 4: " + bookTitle[3]);
            
        }
    }
}
