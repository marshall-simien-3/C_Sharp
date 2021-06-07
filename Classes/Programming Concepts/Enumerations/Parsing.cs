using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization; // Used for parsing function library.

namespace Training_C_Sharp.Classes.Programming_Concepts
{
    public static class Parsing
    {
        /// <summary>
        /// Function for different paring methods. 
        /// The decimal.Parse() function actually will take into account strings that include commas.
        /// </summary>
        public static void String_Parsing()
        {

            try
            {
                string numString1 = "2";
                string numString2 = "2.34";
                string numString3 = "2,000";
                string numString4 = "2,000.34";
                int targetNumInt;
                decimal targetNumDecimal;


                // Using parse to try a simple integer.
                targetNumInt = int.Parse(numString1);
                Console.WriteLine($"First string before parse: {numString1} | After int parse: {targetNumInt}");

                // Using parse to try an integer with a decimal place.
                targetNumDecimal = decimal.Parse(numString2);
                Console.WriteLine($"Second string before parse: {numString2} | After int parse: {targetNumDecimal}");

                // Using parse to try an integer with a comma included.
                targetNumDecimal = decimal.Parse(numString3);
                Console.WriteLine($"Third string before parse: {numString3} | After int parse: {targetNumDecimal}");

                // Using parse to try an integer with a comma and decimal included.
                targetNumDecimal = decimal.Parse(numString4);
                Console.WriteLine($"Fourth string before parse: {numString4} | After int parse: {targetNumDecimal}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\r\nError: {ex.Message}");
            }    

        }

    }
}
