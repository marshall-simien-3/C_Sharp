using System;
using System.Collections.Generic;
using System.Text;

namespace Training_C_Sharp.Classes
{
    public class Basketball
    {
        // Declaring only one public int "totalPoints". The goal is to declare as few variables as possible.
        public int totalPoints;

        /* We could use a declare a new variable passed into the Basketball constructor, instead of "int totalPoints" we could use "int midrangeShot".
        But if we used midrangeShot, what if that shot was not a midrainge shot? What if I wanted to shoot a three?
        By using totalPoints, this allows for me to have variation of what numbers I can pass into the constructor when I instantiate the object insteas of having to always use a 2 (midrangeShot).
        Therefore, we can use "this." keyword in the constructor to differentiate. Note: totalPoints passed into the constructor is a local argument,
        totalPoints everywhere else is referencing the public instance variable. */
        public Basketball(int totalPoints)
        {
            this.totalPoints = totalPoints;
        }
        public void fouled()
        {
            totalPoints = totalPoints + 1;
        }
    }
}
