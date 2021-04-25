﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// place where code is executed. Within the project "Tutorial" 
 namespace Tutorial
{
    //container for Code
    class Free_Write
    {
        // Main function for where instructions are placed for computer to execute.
        static void Main(string[] args)
        {
            // 1) Print out line of text.
            Console.WriteLine("1) Hello Marsh!!");
            Console.WriteLine("Yo");
            Console.WriteLine("Whats up");

            // Create a string variable
            string testing = "2) This is just a test";
            
            // 2) Print out string variable.
            Console.WriteLine(testing);
                // Returns a true value if string contains the following phrase.
                Console.WriteLine(testing.Contains("This"));
                // Returns the seconds character of the string.
                Console.WriteLine(testing[1]);
                // Returns the 4 characters of the string testing starting at index 11. Index includes spaces.
                Console.WriteLine(testing.Substring(11, 4));

            // 3) Print out a floating point number.
            double test_number = 4.54;
            Console.WriteLine("3) " + test_number);

            // 4) Allow user to enter a line of text.
            //This line allows a user to write a line of text without the program jumping to the next executing line. 
            Console.Write("4) Enter your name here: ");
            // Stores the line of text entered as a string.
            string name = Console.ReadLine();
            // 5) Repeat nomenclature for entering age.
            Console.Write("5) Enter your age: ");
            string age = Console.ReadLine();
            // 6) Printout entered text.
            Console.WriteLine("6) Hello " + name + ", you are " + age + " years old!");

            // Create an array of inegers.
            int[] array1 = { 1, 2, 3, 4, 5, 6 };
            array1[1] = 6000;
            //Printout.
            Console.WriteLine(array1[2]);
            Console.WriteLine(array1[1]);

            // 7) Declare & compose 3 strings to output a sentence.
            var string1 = "Hi";
            var string2 = ", my name is Marshman!";
            var string3 = " Whats yours?";
            Console.WriteLine("7)" + string1 + string2 + string3);

            // 8) Append a string to a Stringbuilder object. 
            var sb = new StringBuilder();
            var sb2 = new StringBuilder("Hello man");
            sb.Append("8) Bighead :)");
            Console.WriteLine(sb);
            Console.WriteLine(sb2);

            // 9) String Formatter
            var nine_city = "Indianapolis"; //string
            var nine_temperature = 85.6f; //floating point number
            var nine_date = DateTime.Now; //date & time
            Console.WriteLine(string.Format("9) Welcome to {0}, the temperature is {1} Deg. F, while the date is {2}.", nine_city, nine_temperature, nine_date));

            //Keeps console window up after compiling the code. Waits for an entry of text.
            Console.ReadLine();
        }
    }
} 
