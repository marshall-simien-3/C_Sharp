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
            Console.Write("1) Enter your favorite color please: ");
            var input_color = Console.ReadLine();
            Console.Write("Enter your gender please: ");
            var input_gender = Console.ReadLine();
            one_switch.Switch_Statement(input_color, input_gender);

            // 2) For Each loop statement.
            var numbers = new List<int>() { 1, 3, 5, 4 };
            var sum = 0;
            foreach (var number in numbers)
            {
                sum = sum + number;
            }
            Console.WriteLine($"2) sum: {sum}\n\r");

            // 3) While loop statement.
            var three_while = new Flow_Control();
            three_while.Init_While_Loop();

            // 4) Continue and break statement.
            var four_continue_break = new Flow_Control();
            four_continue_break.Continue_Break();

            Console.ReadLine();
        }
    }
}