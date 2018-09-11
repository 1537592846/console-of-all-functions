using System;

namespace console_of_all_functions.libraries.math
{
    class Prime
    {
        internal static void IsPrime(long number)
        {
            if (number == 1)
            {
                Console.WriteLine("Not a prime number");
                return;
            }

            for(int i = 2; i <= Math.Sqrt(number); i++)
            {
                if(number % i == 0)
                {
                    Console.WriteLine("Not a prime number");
                    return;
                }
            }

            Console.WriteLine("Prime number");
        }

        internal static void Explanation()
        {
            Console.WriteLine("Prime number, by definition, is a natural number that " +
                "has only two divisors, the number 1 and itself.");
        }
    }
}
