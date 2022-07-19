using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace instantiating
{
    class Program
    {
        static void Main(string[] args)
        {
            House londonHouse =
                new House { HousrName = "London street", Members = 3};

            Console.WriteLine("House Name: {0}, Members: {1}", londonHouse.HousrName, londonHouse.Members);
        }
    }
}
    
