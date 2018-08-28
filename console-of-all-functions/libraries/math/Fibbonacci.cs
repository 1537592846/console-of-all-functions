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
    }
}
