using System;
using System.Collections.Generic;
using System.Text;
using Training_C_Sharp.Classes.Programming_Concepts;

namespace Training_C_Sharp
{
    class Lambda_Operators_Main
    {
        static void Main(string[] args)
        {
            var one_lambda = Lambda_Expressions.GenericFunctLambdaExpr1();
            Console.WriteLine($"1) Square expression results: {one_lambda}\r\n");

            var two_lambda = Lambda_Expressions.GenericFunctLambdaExpr2();
            Console.WriteLine($"2) String expression results: {two_lambda}");

            Console.ReadLine();
        }
    }
}
