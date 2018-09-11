using System;

namespace console_of_all_functions.libraries.math
{
    class Factorial
    {
        internal static void Sequence(int quantity)
        {
            Console.WriteLine(CreateSequence(quantity));
        }

        protected static long CreateSequence(long n)
        {
            if (n < 2)
            {
                return 1;
            }

            return CreateSequence(n - 1) * n;
        }

        internal static void Explanation()
        {
            Console.WriteLine("Factorial function is a mathematical operation that takes the number " +
                "and multiples it by every single natural number before it. It only works with " +
                "natural numbers.");
        }
    }
}
