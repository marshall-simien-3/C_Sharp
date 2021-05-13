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
    }
}
