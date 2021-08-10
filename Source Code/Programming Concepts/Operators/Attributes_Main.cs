using System;
using System.Collections.Generic;
using System.Text;
using Training_C_Sharp.Classes.Programming_Concepts.Operators;

namespace Training_C_Sharp
{
    class Attributes_Main
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First Attribute Example: Obsolete");
            Console.WriteLine(Attributes.Multiplier(new List<int>() { 3, 2, 4, 5 }) + "\n\r");
            Console.ReadLine();
        }
    }
}
