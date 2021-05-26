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
            var one_switch = new Flow_Control();
            one_switch.Switch_Statement("red", "hi");
            Console.ReadLine();
        }
    }
}