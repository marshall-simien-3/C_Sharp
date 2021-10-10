using System;
using System.Collections.Generic;
using System.Text;
using Training_C_Sharp.Classes.Programming_Concepts.Data_Types;

namespace Training_C_Sharp
{
    class Nullable_Type_Main
    {
        static void Main (string[] args)
        {
            // 1) Value type int? result.
            Nullable_Types.Value_Types.Value_Types_Int();

            // 2) Value type bool? result.
            Nullable_Types.Value_Types.Value_Types_Bool();

            Console.ReadLine();
        }
    }
}
