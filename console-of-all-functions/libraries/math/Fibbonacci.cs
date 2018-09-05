using System;
using System.Collections.Generic;
using System.Linq;

namespace console_of_all_functions.libraries.math
{
    public class Fibbonacci
    {
        internal static void Sequence(int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write(Position(i) + " ");
            }
        }

        internal static int Position(int position)
        {
            var root = Math.Sqrt(5);
            var phi = (1 + root) / 2;
            return int.Parse(Math.Round(Math.Pow(phi, position) / root).ToString());
        }

        internal static void SequenceWithTwoNumbers(int numberA, int numberB, int count)
        {
            List<int> numberList = new List<int>();
            numberList.Add(numberA);
            numberList.Add(numberB);
            for (int i = 0; i < count - 2; i++)
            {
                numberList.Add(numberList.ElementAt(numberList.Count - 1) + numberList.ElementAt(numberList.Count - 2));
            }

            foreach(var number in numberList)
            {
                Console.Write(number + " ");
            }
        }

        internal static void Explanation()
        {
            Console.WriteLine("The Fibbonacci sequence is a sequence of numbers where " +
                "the next element is equal to the sum of the two before. " +
                "The most famous sequence is 0, 1, 1, 2, 3, 5, 8, 13, ... and is known " +
                "as Fibbonacci sequence, but any two numbers can construct a sequence, " +
                "like Lukas sequence (2, 1, 3, 4, 7, 11, ...). There is a formula " +
                "capable to determine the number at any position, starting at zero, " +
                "of the main sequence F(x)=((1+√5)/2)^x/√5 | F(x) ε N.");
        }
    }
}
