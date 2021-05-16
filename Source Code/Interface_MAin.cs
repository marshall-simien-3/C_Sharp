using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee_Overview;
using Training_C_Sharp.Classes.Vehicles;

// place where code is executed. Within the project.
 namespace Training_C_Sharp
{

    //container for Code

    /* Interfaces are just like abstract classes. You can apply the attributes of an interface towards many different classes that share the same characteristics.
The interface states the attributes, the classes define the attributes, and the main code calls the attributes/methods. */
    class Interface_Main
    {
        // Main function for where instructions are placed for computer to execute.
        static void Main()
        {
            Sportscar mustang = new Sportscar("Mustang", 4, "black");
            if (mustang is Sportscar)
            {
                mustang.move();
                mustang.stop();
            } else
            {
                Console.Write($"Cannot drive the {mustang.brand}");
            }
            Console.ReadLine();
        }
    }
} 
