// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExtensionMethod
{
    class Employee
    {
        public void Main(string[] args)
        {
            string country = "Great britain";
            Console.WriteLine(country.FirstLetterLower());

            List<string> cities = new List<string>(0);
            cities.Add("seoul");
            cities.Add("tokyo");
            cities.Add("berlin");
            cities.Add("seoul");
            cities.Add("istanbul");
            cities.Add("paris");

            List<string> result = cities.RemoveDuplicate();
            foreach(string city in result)
                Console.WriteLine(city);
        }
    }
}
