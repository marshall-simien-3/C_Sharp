using System;
using System.Collections.Generic;
using System.Text;

namespace Training_C_Sharp.Classes.Programming_Concepts.Operators
{
    // Attributes allow you to write declarative info to you code. Attributes can use parameters.
    public static class Attributes
    {
        /// <summary>
        /// Declare the below function as obsolete. There is a replacement function below it accepting an int List as a parameter. This will be used instead.
        /// </summary>
        /// <param name="firstMult"></param>
        /// <param name="SecondMult"></param>
        /// <returns></returns>
        [Obsolete("Use the Multiplier function with List parameter passed.")]
        public static int Multiplier(int firstMult, int SecondMult)
        {
            return firstMult * SecondMult;
        }

        /// <summary>
        /// Function to use in place of obsolete function.
        /// </summary>
        /// <param name="multList"></param>
        /// <returns></returns>
        public static int Multiplier (List<int> multList)
        {
            int Sum = 1;
            foreach(int Number in multList)
            {
                Sum = Sum * Number;
            }
            return Sum;
        }
    }
}
