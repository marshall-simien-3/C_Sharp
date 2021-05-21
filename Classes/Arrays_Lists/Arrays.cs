using System;
using System.Collections.Generic;
using System.Text;

namespace Training_C_Sharp.Classes.Arrays_Lists
{
    public class Arrays
    {
        // Array name
        public string[] my_family;

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
    }
}

