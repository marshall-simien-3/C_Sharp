using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training_C_Sharp.Classes.Arrays;

// place where code is executed. Within the project.
namespace Training_C_Sharp
{

    //container for Code
    class Arrays_Main
    {
        // Main function for where instructions are placed for computer to execute.
        static void Main()
        {
            // 1) Call methods from Arrays class.
            Arrays one_array = new Arrays();
            Console.WriteLine($"1) My name is {one_array.my_family[0]}, my lover's name is {one_array.my_family[1]}, and my dog's name is {one_array.my_family[2]}.");
            one_array.upsize_array(5); // Upsize the current array.
            one_array.my_family[3] = "Auggie";
            one_array.my_family[4] = "Grace";
            Console.WriteLine($"My brother is {one_array.my_family[3]}, and my sister is {one_array.my_family[4]}.");
            Console.WriteLine($"Length of array: {one_array.my_family.Length}");

            Console.ReadLine();

        }
    }
}