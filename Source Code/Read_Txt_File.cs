using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;  // Used for reading / writing to files.
using NLog;       // USed for logging purposes.

// place where code is executed. Within the project.
namespace Training_C_Sharp
{

    //container for Code
    class Read_Txt_File
    {

        // Main function for where instructions are placed for computer to execute.
        // Will use try-catch statement while reading in info from text file.
        static void Main()
        {
            Logger logger = LogManager.GetCurrentClassLogger();  // Instantite the logger.

            try
            {
                using (var read = new StreamReader(@"C:\Users\msimi\source\repos\Training-C_Sharp\Example_Files\Read_In.txt"))
                {
                    var contents = read.ReadToEnd();  // Read entire text from txt file, and place string into "contents".
                    Console.WriteLine(contents);
                    var date = DateTime.Now;
                    logger.Trace($"Text file reading has started on {date}");
                }
            }
            catch (System.IO.DirectoryNotFoundException ex)
            {
                Console.WriteLine("Could not find directory.");   // Outputs to cmd console.
                logger.Error(ex.Message);  // Outputs to logger.
            }
            catch (System.IO.FileNotFoundException ex)
            {
                Console.WriteLine("Could not locate the file.");
                logger.Error(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unknown error occured: {ex.Message}");
            }

            Console.ReadLine();
        }

    }
}