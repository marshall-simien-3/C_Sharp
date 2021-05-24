using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training_C_Sharp.Classes.Arrays_Lists;

// place where code is executed. Within the project.
namespace Training_C_Sharp
{

    //container for Code
    class Arrays_Lists_Main
    {
        // Main function for where instructions are placed for computer to execute.
        static void Main()
        {
            // 1) Call methods from Arrays class.
            var one_array = new Arrays();
            Console.WriteLine($"1) My name is {one_array.my_family[0]}, my lover's name is {one_array.my_family[1]}, and my dog's name is {one_array.my_family[2]}.");
            one_array.upsize_array(5); // Upsize the current array.
            one_array.my_family[3] = "Auggie";
            one_array.my_family[4] = "Grace";
            Console.WriteLine($"My brother is {one_array.my_family[3]}, and my sister is {one_array.my_family[4]}.");
            Console.WriteLine($"Length of array: {one_array.my_family.Length}");

            var two_array = new Arrays();
            two_array.Arrays_2();
            Console.WriteLine($"Average of family ages: {two_array.family_ages.Average()}\n\r");


            // 2) Call methods from Lists class.
            var two_list = new Lists();
            Console.Write("2) List of all the coil widths: "); 
            Console.WriteLine(String.Join(", ", two_list.coil_widths)); // Comma separates all items in list once outputted.
            Console.WriteLine($"Is this width contained within list? Answer: {two_list.normal_widths(24)}\n\r");

     
            // 3) Create another list. 
            var three_list = new List<string> { "Me", "Myself", "I" };
            Console.WriteLine($"3) List of all names: " + String.Join(", ", three_list) + "\n\r"); // Comma separates all items in list once outputted.

            // 4) Create a dictionary.
            var four_dictionary_words = new Dictionary<string, string>();
            four_dictionary_words.Add("cap", "to bluff or not truthful"); // Dictionary structure: ("[word]", "[definition]")
            four_dictionary_words.Add("lit", "to get hyped");

            List<string> four_keys = four_dictionary_words.Keys.ToList();
            Console.WriteLine($"4) List the dictionary keys: {String.Join(", ", four_keys)}");
            Console.WriteLine($"Dictionary key count: {four_keys.Count}");

            Console.ReadLine();

        }
    }
}