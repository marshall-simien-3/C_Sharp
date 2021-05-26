using System;
using System.Collections.Generic;
using System.Text;

namespace Training_C_Sharp.Classes.Flow_Control
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
                Console.WriteLine($"1) {statement_color_result} {statement_gender_result}\n\r");
            }

        }

    }
}