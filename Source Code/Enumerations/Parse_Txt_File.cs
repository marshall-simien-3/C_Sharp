using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;  // Used for reading / writing to files.
using System.Text.RegularExpressions;

// place where code is executed. Within the project.
namespace Training_C_Sharp
{

    //container for Code
    class Parse_Txt_File
    {
        // Main function for where instructions are placed for computer to execute.
        /// <summary>
        /// Goal is to read in string from txt file, parse out the numbers & return them as floats.
        /// Will use try-catch statement while reading an parsing info from text file.
        /// </summary>
        static void Main()
        {
            try
            {
                using (var read = new StreamReader(@"C:\Users\msimi\source\repos\Training-C_Sharp\Example_Files\Read_In_Parse.txt"))
                {
                    var record = read.ReadLine(); // Read in contents from text file.
                    Console.WriteLine($"Initial file string: {record}");
                    record = Regex.Replace(record, "[A-Za-z: ]", ""); //remove all alphabets and colon within string.
                    Console.WriteLine($"String after alphabets removed: {record}");
                    record = record.TrimEnd('.'); // Remove the . from the end of the string.
                    Console.WriteLine($"String after period removed: {record}\n\r");
                    var numbers = record.Split(','); // Separate the numbers using the commas within the string.

                    Console.WriteLine("Below are the final results:");
                    foreach (var num in numbers)
                    {
                        var result = float.Parse(num);
                        Console.WriteLine(result);
                    }
                }
            }

            catch (System.IO.FileNotFoundException ex)
            {
                Console.WriteLine("Could not locate the file.");
            }

            catch (Exception ex)
            {
                Console.WriteLine($"An unknown error occured: {ex.Message}");
            }

            Console.ReadLine();
        }
    }
}
