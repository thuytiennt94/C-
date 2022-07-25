// See https://aka.ms/new-console-template for more information
using System;
class MainClass
{
    public static int AnExceptionFunction (int value)
    {
        if (value == 0)
            throw new ArgumentOutOfRangeException ("Divide By 0 error!");
        int x = 20;
        return x;
    }
    public static void Main()
    {
        int value = 0;
        try
        {
            value = AnExceptionFunction(10);
            Console.WriteLine ("Value = {0}", value);
            AnExceptionFunction(0);
            Console.WriteLine("value = {0} ", value);
        }
        catch (Exception e)
        {
            Console.WriteLine ("Caught an exception {0}. Continuing" , e);
        }
        Console.WriteLine("Done");
    }
}