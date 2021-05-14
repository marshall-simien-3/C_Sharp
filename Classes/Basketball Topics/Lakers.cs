using System;
using System.Collections.Generic;
using System.Text;

namespace Training_C_Sharp.Classes
{
    public class Lakers : Teams
    {
        public string lebron_position { get; set; }
        public string kuzma_hair_type { get; set; }
        public int lebron_jersey_number { get; set; }

        public override int players_of_the_month()  // Override allows the base class method to be uniquely implemented into the derived class.
        {
            return 4 + 3;
        }

        // Overiding a Virtual method - allows the method defined in the base class to be overritten.
        public override string best_player(string player_name)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(player_name + " is not the best player anymore.");
            return sb.ToString();
        }
    }
}
