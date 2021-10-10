using System;
using System.Collections.Generic;
using System.Text;

namespace Training_C_Sharp.Classes.Programming_Concepts.Data_Types
{
    /// <summary>
    /// In C# there are 2 different categories of types: Value types (int, float, double, string, structs, etc..) and Reference Types (class, arrays, delegates, etc...)
    /// By default, value types are non-nullable, but we use ? to make them nullable (I.e., int? j = 0).
    /// </summary>
    public static class Nullable_Types
    {
        public static class Value_Types
        {
            /// <summary>
            /// Method for declaring a basic value type int?
            /// </summary>
            /// <returns></returns>
            public static void Value_Types_Int()
            {
                int? i = 23;
                int result = i ?? 0; // This line states "if i is null then value is 0, else the value is the value of i, which is 23." 
                Console.WriteLine($"1) int? value is {result}");           
            }

            /// <summary>
            /// Method for declaring a basic value type bool?
            /// </summary>
            public static void Value_Types_Bool()
            {
                bool? i = null;
                if (i is null)
                {
                    Console.WriteLine("2) bool? value is null");
                }
                else
                {
                    Console.WriteLine("2) bool? value unknown");
                }
            }
            
        }
    }
 }
