using System;
using System.Collections.Generic;
using System.Text;

namespace Training_C_Sharp.Classes
{
    public class Work
    {
        public string Name { get; set; }  // Access modifier public string "Name".
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

        private string _twitterAddress;  /* By declaring this variable as private an using it within the following public function allows for encapsulation. 
        Encapsulation is the inability of someone changing a private parameter when calling or manipulating a function. */
        public string TwitterAddress    // Access modifier string using logic.
        {
            get { return _twitterAddress; }
            set
            {
                if (value.StartsWith("@"))
                {
                    _twitterAddress = value;
                }
                else
                {
                    throw new Exception("The address should begin with an @");
                }
            }
        }
        
        // Instantiate a basic Constructor
        public Work()
        {
            Name = "Nucor Steel";
            PhoneNumber = "337-853-9429";
        }

        // Less basic constructor. Parameter passing.
        public Work(string workName, string workPhoneNumber)
        {
            Name = workName;
            PhoneNumber = workPhoneNumber;
        }

        // Creating a method.
        public static float AverageScores(float a, float b, float c)
        {
            var result = (a + b + c) / 3;
            return result;
        }


        // Overloading method. Same as "AverageScores", just a different return type (int).
        // Static so we do not have to instantiate the class. Do not have to create an object.
        public static int AverageScores(int a, int b, int c)
        {
            var result = (a + b + c) / 3;
            return result;
        }
    }
}
