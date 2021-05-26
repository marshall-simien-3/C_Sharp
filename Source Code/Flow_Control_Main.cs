using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training_C_Sharp.Classes.Flow_Control;

// place where code is executed. Within the project.
namespace Training_C_Sharp
{

    //container for Code
    class Flow_Control_Main
    {
        // Main function for where instructions are placed for computer to execute.
        static void Main()
        {
            // 1) Call switch statement.
            var one_switch = new Flow_Control();
            one_switch.Switch_Statement("red", "hi");

            // 2) For Each loop statement.
            var numbers = new List<int>() { 1, 3, 5, 4 };
            var sum = 0;
            foreach (var number in numbers)
            {
                sum = sum + number;
            }
            Console.WriteLine($"2) sum: {sum}\n\r");


            Console.ReadLine();
        }
    }
}