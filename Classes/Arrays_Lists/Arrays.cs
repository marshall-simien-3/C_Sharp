using System;
using System.Collections.Generic;
using System.Text;

namespace Training_C_Sharp.Classes.Arrays_Lists
{
    public class Arrays
    {
        // Array names
        public string[] my_family;
        public double[] family_ages;

        /// <summary>
        /// Constructor. Define array size 3.
        /// </summary>
        public Arrays()
        {
            my_family = new string[3] { "Marsh", "Baylee", "Wolf" };
        }

        /// <summary>
        /// Resizing the array.
        /// </summary>
        public void upsize_array(int newSize)
        {
            Array.Resize(ref my_family, newSize);
        }

        public void Arrays_2()
        {
            family_ages = new double[3] { 25, 16, 21 };
        }
    }
}

