// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Text;

namespace Company
{
    class Product
    {
        static void Main(string[] args)
        {
            Object objProductID;
            Object objbProductName;
            Object objPrice;
            Object objQuantity;

            //accepting and converting the details of the products
            //into reference types using implicit boxing
            Console.Write("Enter the id of product: ");
            objProductID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the name of product: ");
            objbProductName = Console.ReadLine();

            Console.Write("Enter price: ");
            objPrice = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter quantity: ");
            objQuantity = Convert.ToInt32(Console.ReadLine());

            //converting objects into their relevant types
            //using explicit unboxing

            int ProductID = (int)objProductID;
            string ProductName = (string)objbProductName;
            double Price = (double)objPrice;
            int Quantity = (int)objQuantity;
            double amtPayable = (int)objQuantity * Price;

            //DIsplaying the details od the product
            Console.WriteLine("\nProduct Details:");
            Console.WriteLine("Product ID:" + ProductID);
            Console.WriteLine("Product Name: " + ProductName);
            Console.WriteLine("Price: $" + objPrice);
            Console.WriteLine("Quantity :" + objQuantity);
            Console.WriteLine("Amt Payable {0:F2}:", amtPayable);

        }
    }
}