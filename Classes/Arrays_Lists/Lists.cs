using System;
using System.Collections.Generic;
using System.Text;

namespace Training_C_Sharp.Classes.Arrays_Lists
{
    public class Lists
    {
        public List<int> coil_widths { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public Lists()
        {
            coil_widths = new List<int>() { 24, 25 }; // Declaring items in the list.
            coil_widths.Add(30); // Add 30 into the list by using the .Add method.
        }

        /// <summary>
        /// Bool method to check if imput inches is contained within the coil width list.
        /// </summary>
        public bool normal_widths(int normal_width)
        {
            return coil_widths.Contains(normal_width);
        }
    }
}
