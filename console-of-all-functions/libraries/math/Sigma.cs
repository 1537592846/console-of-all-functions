using System;

namespace console_of_all_functions.libraries.math
{
    class Sigma
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

            return CreateSequence(n - 1) + n;
        }


        internal static void Explanation()
        {
            Console.WriteLine("Sigma function is a mathematical operation that sums every number before " +
                "the starting number, including the starting number. It can be used only with natural numbers.");
        }
    }
}
