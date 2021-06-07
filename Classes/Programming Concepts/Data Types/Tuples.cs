using System;
using System.Collections.Generic;
using System.Text;

namespace Training_C_Sharp.Classes.Programming_Concepts
{
    public static class Tuples
    {
    
        // Used for option #3.
        public static void TupleClassCreation1(int element_1, string element_2, List<double> element_3)
        {
            var Tuple_1 = Tuple.Create(element_1, element_2, element_3);
            Console.WriteLine($"Item 1: {Tuple_1.Item1}, Item 2: {Tuple_1.Item2}, Item 3: {Tuple_1.Item3[0]}\r\n");
        }


        // Public Tuple variable declared and defined for option #4.
        public static Tuple<int, string, char> Tuple_2 = new Tuple<int, string, char>(54, "Tuple 2", 'j');

        // Usd for option #4.
        public static void TupleClassCreation2()
        {
            Console.WriteLine($"Item 1: {Tuple_2.Item1}, Item 2: {Tuple_2.Item2}, Item 3: {Tuple_2.Item3}");
        }
    }
}
