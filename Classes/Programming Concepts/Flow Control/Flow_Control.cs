using System;
using System.Collections.Generic;
using System.Text;

namespace Training_C_Sharp.Classes.Programming_Concepts
{
    public class Flow_Control
    {
        // Public strings.
        public string statement_color_result;
        public string statement_gender_result;
        public string statement_color_carryover;
        public string statement_gender_carryover;
        public string input_color;
        public string input_gender;

        /// <summary>
        ///Testing out a switch statement, looks for your favorite color and gender.
        ///After the switch statement function executes, it will call a check statement function.
        ///This check statement function will check to see if your entries fit the scope. If not, the check statement will
        ///prompt the user to re-input the incorrect fields again, then call the switch statement function once again.
        /// </summary>
        /// <param name="color"></param>
        /// <param name="gender"></param>
        public void Switch_Statement(string color, string gender)
        {
            string string_result;
            string string_result_2;

            switch (color.ToLower())
            {
                case "black":
                    string_result = "Your color is black.";
                    break;
                case "blue":
                    string_result = "Your color is blue.";
                    break;
                case "red":
                    string_result = "Your color is red.";
                    break;
                case "glitter":
                    string_result = "Your color is glitter.";
                    break;
                default:
                    string_result = "You have no color.";
                    break;
            }

            switch (gender.ToLower())
            {
                case "male":
                    string_result_2 = "You are a male.";
                    break;
                case "female":
                    string_result_2 = "You are a female.";
                    break;
                default:
                    string_result_2 = "What is your gender?";
                    break;
            }

            // Carryover color and gender entries.
            statement_color_carryover = color.ToLower();
            statement_gender_carryover = gender.ToLower();

            // Store switch statement results for color and gender.
            statement_color_result = string_result;
            statement_gender_result = string_result_2;

            // Check the switch statements.
            Check_Switch_Statement();
        }

        /// <summary>
        /// Verifies if the most recent entries are valid. If not, prompt user for entry(s) and call switch statement again.
        /// </summary>
        public void Check_Switch_Statement()
        {

            if ((statement_color_result == "You have no color.") & (statement_gender_result == "What is your gender?"))
            {
                Console.Write("Enter your correct color please: ");
                input_color = Console.ReadLine();
                Console.Write("Enter your correct gender please: ");
                input_gender = Console.ReadLine();
                Switch_Statement(input_color, input_gender);
            }

            else if (statement_gender_result == "What is your gender?")
            {
                Console.Write("Enter your correct gender please: ");
                input_gender = Console.ReadLine();
                Switch_Statement(statement_color_carryover, input_gender);
            }

            else if (statement_color_result == "You have no color.")
            {
                Console.Write("Enter your correct color please: ");
                input_color = Console.ReadLine();
                Switch_Statement(input_color, statement_gender_carryover);
            }
            else
            {
                Console.WriteLine(statement_color_result + " " + statement_gender_result + "\n\r");
            }

        }

        /// <summary>
        /// Calls the while loop function after user input prompt.
        /// </summary>
        public void Init_While_Loop()
        {
            Console.Write("3) Enter your starting point: ");
            int input_starting_point = int.Parse(Console.ReadLine());

            Console.Write("Enter your finishing point: ");
            int input_finishing_point = int.Parse(Console.ReadLine());

            While_Loop(input_starting_point, input_finishing_point);
        }

        /// <summary>
        /// While loop class will iterate through a starting point integer and sum the amount of counts until a reached finishing points.
        /// It basically results the difference between starting point and finishing point.
        /// </summary>
        /// <returns></returns>
        private void While_Loop(int starting_point, int finishing_point)
        {
            if (starting_point <= finishing_point)
            {
                int sum = 0;
                //int counter = 0;

                while (starting_point < finishing_point)
                {
                    sum = sum + 1;
                    starting_point++;
                    //counter++;
                }
                Console.WriteLine($"The difference between starting point & ending point is {sum}.\n\r");

            } else

            {
                Console.WriteLine("Your finishing point needs to be greater than your starting point.");
                Init_While_Loop();
            }
        }

        /// <summary>
        /// Function for continue & break statements.
        /// </summary>
        public void Continue_Break()
        {
            var words = new List<string>() { "Marsh", "Baylee", "George", "Heather", "Ben" };
            foreach (var word in words)
            {
                if (word.StartsWith("B")) { continue; }
                if (word.StartsWith("H")) { break; }

                Console.WriteLine(word);

            }
        }

    }
}