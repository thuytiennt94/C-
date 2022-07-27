// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Text;

namespace Bai05
{
    class VD1
    {
        static void Main(string[] args)
        {
            byte[] a = new byte[5];

            //nhap mang
            try
            {
                for (int i = 0; i <= 5; i++)
                {
                    Console.WriteLine("a[{0}] = ", i + 1);
                    a[i] = Convert.ToByte(Console.ReadLine());
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("khong duoc nhap ki tu cho mang so");
            }
            catch(OverflowException ex)
            {
                Console.WriteLine("khong duoc nhap gia tri nam ngoai mien 0-255");
            }
            for (int i = 0; i < 5; i++)
                Console.Write(" {0} ", a[i]);
        }
    }
}