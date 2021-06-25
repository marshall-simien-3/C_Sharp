using System;
using System.Collections.Generic;
using System.Text;

namespace Training_C_Sharp.Classes.Programming_Concepts
{
    /// <summary>
    /// We use a lambda expression to create an anonymous function. Syntax: (input-parameters) => expression
    /// </summary>
    public static class Lambda_Expressions
    {
        /// <summary>
        /// Square of a Func defined by a lambda expression.
        /// </summary>
        /// <returns></returns>
        public static int GenericFunctLambdaExpr1()
        {
            Func<int, int> square = x => x * x;
            return square(4);
        }

        public static string GenericFunctLambdaExpr2()
        {
            Func<string, string, string> greeting = (friend_name, my_name) =>
            {
                string statement = $"Hello, {friend_name}, my name is {my_name}.";
                return statement;
            };
            return greeting("Bob", "Marshall");
        }
    }
}
