// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Module6
{
    class outParameters
    {
        static void Depreciation(out int val)
        {
            val = 200000;
            int dep = val * 5 / 100;
            int amt = val - dep;
            Console.WriteLine("depreciation amount: " + dep);
            Console.WriteLine("reduced value after depreciation" + amt);
        }
        static void Main(string[] args)
        {
            int value;
            Depreciation(out value);
        }
    }
}