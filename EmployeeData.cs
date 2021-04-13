using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    //container for Code
    class EmployeeData
    {
        // Public class definition for Employee functions.
        public class Employee
        { 
            public static int employeeCounter; // Define employee incremental counter.

            // Function for writing out employee name & ID.
            public static void Employee1(string name, string id)
            {
                Console.WriteLine("Employee Name: " + name);
                Console.WriteLine("Employee ID: " + id);
            }

            // Function that increments the employee counter by 1.
            public static int AddEmployee()
            {
                return ++employeeCounter;
            }
        }

        // Main function for where instructions are placed for computer to execute.
        static void Main()
        {
            Console.Write("Enter employee name: ");
            string name = Console.ReadLine();
            Console.Write("Enter employee ID: ");
            string id = Console.ReadLine();
            Console.Write("Enter the current number of employees: ");
            string n = Console.ReadLine();

            Employee.employeeCounter = Int32.Parse(n);  // Converts string entry to integer 32 bit.
            Employee.AddEmployee();

            Console.WriteLine();    // Line break
            Employee.Employee1(name, id);   // Outputs employee name & ID function.
            Console.WriteLine("Number of current employees: " + Employee.employeeCounter);  // Outputs employee counter.
            Console.ReadLine();    //Keeps console window up after compiling the code. Waits for an entry of text.
        }
    }
}
