using NCalc;
using System;

namespace console_of_all_functions.libraries.math
{
    class Equation
    {
        internal static void Calculate(string expression)
        {
            Console.WriteLine(expression+"="+new Expression(expression).Evaluate());
        }

        internal static void Explanation()
        {
            Console.WriteLine("This can calculate string expressions.\n" +
                "Avaliable operations to use:\n" +
                "+:         Addition\n" +
                "-:         Subtraction\n" +
                "*:         Multiplication\n" +
                "/:         Division\n" +
                "%:         Modular operation\n" +
                "^:         Binary Sum\n" +
                "or:        Logical OR\n" +
                "and:       Logical AND\n" +
                "not:       Logical NOT\n" +
                ">:         Greater than\n" +
                "<:         Lesser than\n" +
                ">=:        Greater than or Equal to\n" +
                "<=:        Lesser than or Equal to\n" +
                "!=:        Not equal to\n" +
                "Pow(a,b):  Power function");
        }
    }
}
