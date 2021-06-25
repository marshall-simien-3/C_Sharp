using System;
using System.Collections.Generic;
using System.Text;
using static Training_C_Sharp.Classes.Programming_Concepts.Structs;

namespace Training_C_Sharp
{
    class Structs_Main
    {
        static void Main(string[] args)
        {
            StructBasicArithmetic one_ArithmeticResult = new StructBasicArithmetic(5.3, 4.4);
            Console.WriteLine($"1) {one_ArithmeticResult.result2}\n\r");

            StructGrid two_GridResult = new StructGrid();
            Console.WriteLine($"2) Coordinate results: {two_GridResult.Coordinates(3, 4.5)}");
            two_GridResult.ColumnsRows(5,6);
            Console.WriteLine($"Number of Columns: {two_GridResult.numofColumns}, Number of Rows: {two_GridResult.numofRows}");

            Console.ReadLine();
        }
    }
}
