using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Book objBook = new Book();
            objBook.Input("C#-the complete reference");
            Console.WriteLine(objBook.Print());
            Console.ReadKey();
        }
    }
}
