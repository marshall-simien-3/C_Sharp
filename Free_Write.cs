using System;
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
            // Repeat nomenclature for entering age.
            Console.Write("Enter your age: ");
            string age = Console.ReadLine();
            // Printout entered text.
            Console.WriteLine("Hello " + name + ", you are " + age + " years old!");

            // 5) create an array of inegers.
            int[] array1 = { 1, 2, 3, 4, 5, 6 };
            array1[1] = 6000;
            //Printout.
            Console.WriteLine(array1[2]);
            Console.WriteLine(array1[1]);

            //Keeps console window up after compiling the code. Waits for an entry of text.
            Console.ReadLine();  
        }
    }
} 
