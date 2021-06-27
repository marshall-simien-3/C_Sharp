using System;
using System.Collections.Generic;
using System.Text;

namespace Training_C_Sharp.Classes.Programming_Concepts
{
    /// <summary>
    /// An enumeration type (or enum type) is a value type defined by a set of named constants of the underlying integral numeric type. 
    /// 
    /// By default the all constants of the Enum are of type Int, and the index of the first sonstant begins at 0.
    /// By setting C_Sharp = 1, this allow that constant to begin at index 1 instead of default 0.
    /// </summary>
    public enum ProgrammingLanguages
    {
        C_Sharp = 1,
        C_PlusPlus,
        Java,
        Python,
        Fortran
    }

    public static class EnumPractice{
        public static void WhichLanguageDoYouPrefer(ProgrammingLanguages language)
        { 

            switch (language)
            {
                case ProgrammingLanguages.C_Sharp:
                    Console.WriteLine($"1) You like to code in {ProgrammingLanguages.C_Sharp.ToString().Replace("_"," ")}, index {Convert.ToInt32(ProgrammingLanguages.C_Sharp)}");
                    break;
                case ProgrammingLanguages.C_PlusPlus:
                    Console.WriteLine($"1) You like to code in {ProgrammingLanguages.C_PlusPlus.ToString().Replace("_PlusPlus"," ++")}, index {Convert.ToInt32(ProgrammingLanguages.C_PlusPlus)}");
                    break;
                case ProgrammingLanguages.Java:
                    Console.WriteLine($"1) You like to code in {ProgrammingLanguages.Java.ToString()}, index {Convert.ToInt32(ProgrammingLanguages.Java)}");
                    break;
                case ProgrammingLanguages.Python:
                    Console.WriteLine($"1) You like to code in {ProgrammingLanguages.Python.ToString()}, index {Convert.ToInt32(ProgrammingLanguages.Python)}");
                    break;
                case ProgrammingLanguages.Fortran:
                    Console.WriteLine($"1) You like to code in {ProgrammingLanguages.Fortran.ToString()}, index {Convert.ToInt32(ProgrammingLanguages.Fortran)}");
                    break;
                default:
                    throw new Exception("1) Not a valid entry.");
            }
        }
    }


}
