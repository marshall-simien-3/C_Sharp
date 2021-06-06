using System;
using System.Collections.Generic;
using System.Text;
using Training_C_Sharp.Interfaces;

namespace Training_C_Sharp.Classes.Vehicles
{

// This class is using attributes from Interface "Vehicle".
    public class Sportscar : Vehicle
    {
        public string brand { get; set; }
        public int num_of_wheels { get; set; }
        public string color { get; set; }
        public int horsepower { get; set; }
        public double speed { get; set; }

        public void move()
        {
            Console.WriteLine($"The {color} {brand} goes up to {speed} MPH");
        }

        public void stop()
        {
            Console.WriteLine($"The {brand} defitely does stop.");
        }

        // Constructor for Sportscar
        public Sportscar (string brand = "No brand", int num_of_wheels = 0, string color = "No color", int speed = 0)  // Default values passed in if no parameters are declared when called.
        {
            this.brand = brand;
            this.color = color;
            this.num_of_wheels = num_of_wheels;
            this.speed = speed;
        }
    }
}
