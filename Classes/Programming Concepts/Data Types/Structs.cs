using System;
using System.Collections.Generic;
using System.Text;

namespace Training_C_Sharp.Classes.Programming_Concepts
{
    /// <summary>
    /// Structures are value type variables that can encapsulate data and related functionality.
    /// A struct's constructor must have one or more parameters passed in.
    /// </summary>
    public class Structs
    {
        /// <summary>
        /// Basic structure with aritmetic.
        /// </summary>
        public struct StructBasicArithmetic
        {
            public double result1;
            public double result2;

            public StructBasicArithmetic(double variable1, double variable2)
            {
                result1 = (55.3 + 5) * variable1;
                result2 = variable2 % 2;
            }
        }

        /// <summary>
        /// Structure for grid parameters.
        /// </summary>
        public struct StructGrid
        {
            private double X;
            private double Y;
            private const int offset = 4;
            public string Coordinates(double startingposX, double startingposY)
            {
                X = startingposX + offset;
                Y = startingposY;
                string result = "(" + X.ToString() + ", " + Y.ToString() + ")";
                return result;
            }


            public int numofColumns;
            public int numofRows;
            public void ColumnsRows(int initColumns, int initRows)
            {
                numofColumns = initColumns;
                numofRows = initRows;
            }

        }

    }
}
