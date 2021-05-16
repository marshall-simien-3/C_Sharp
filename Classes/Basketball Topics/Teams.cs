using System;
using System.Collections.Generic;
using System.Text;

namespace Training_C_Sharp.Classes
{
    public abstract class Teams // Abstract clarifies that Teams is a base class and cannot be instantiated on its own. Can only be inherited by derived classes.
    {
        public string team_colors { get; set; }
        public string team_mascot { get; set; }
        public int team_ranking { get; set; }

        /* An Abstract method/function is declared below.
        Abstract methods allow derived classes to use the same function name, but implement them differently in each darived class. */
        public abstract int players_of_the_month();

        // Declaring a Virtual method - allows the method defined in the base class to be overwritten later in a derived class.
        public virtual string best_player(string player_name)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(player_name + " is the best player now.");
            return sb.ToString();
        }
    }
}
