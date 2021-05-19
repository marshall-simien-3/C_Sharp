using System;
using System.Collections.Generic;
using System.Text;

namespace Training_C_Sharp.Classes.Arrays
{
    public class Arrays
    {
        // Array name
        public string[] my_family;

        // Define array size 3.
        public Arrays()
        {
            my_family = new string[3] { "Marsh", "Baylee", "Wolf" };
        }

        // Resizing the array.
        public void upsize_array(int newSize)
        {
            Array.Resize(ref my_family, newSize);
        }
    }
}

