using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training_C_Sharp.Classes.Programming_Concepts;

// place where code is executed. Within the project.
namespace Training_C_Sharp
{

    //container for Code
    class Tuples_Main
    {
        // Main function for where instructions are placed for computer to execute.
        static void Main()
        {
            // Creating a tuple option #1. Tuple is declared, defined, and outputted in the main function. Defined using Tuple.Create() function.
            Console.WriteLine("Option #1:");
            var tuple1 = Tuple.Create(234, "Hello", new List<double>() { 3.2, 3.3 });
            Console.WriteLine($"Item 1: {tuple1.Item1}, Item 2: {tuple1.Item2}, Item 3: {tuple1.Item3[0]}\r\n");

            // Creating a tuple option #2. Tuple is declared, defined and outputted in main function. Defined differently than option #1.
            Console.WriteLine("Option #2:");
            var tuple2 = new Tuple<int, string, string>(456, "Hello", "What's Up");
            Console.WriteLine($"Item 1: {tuple2.Item1}, Item 2: {tuple2.Item2}, Item 3: {tuple2.Item3}\r\n");

            // Creating a tuple option #3. Tuple is defined in main function, values are passed into class, and outputted there.
            Console.WriteLine("Option #3:");
            Tuples.TupleClassCreation1(88, "Yo mama", new List<double>() { 3.2, 3.3 });

            // Creating a tuple option #4. Tuple is declared, defined, and outputted withn class.
            Console.WriteLine("Option #4:");
            Tuples.TupleClassCreation2();

            Console.ReadLine();
        }
    }
}