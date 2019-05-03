using System;
using System.Collections.Generic;

namespace console_of_all_functions.libraries.math
{
    class JosephusCircle
    {
        internal static void SimpleCircle(int people)
        {
            string binary = Convert.ToString(people, 2);
            binary = binary.Substring(1) + "1";
            Console.WriteLine("Survivor position: " + Convert.ToInt32(binary, 2));
        }

        internal static void ComplexCircle(int people, int jump)
        {
            if (jump == 1)
            {
                SimpleCircle(people);
                return;
            }

            List<int> list = new List<int>();

            for (int i = 0; i < people; i++)
            {
                list.Add(i + 1);
            }

            int pos = 0;
            int posKill = 0;

            while (list.Count > 1)
            {
                posKill = (pos + jump) % list.Count;
                if (list[pos] == list[posKill])
                {
                    posKill=posKill%list.Count;
                }
                list.RemoveAt(posKill);
                pos = posKill%list.Count;
            }

            Console.WriteLine("Survivor position: " + list[0]);
        }

        internal static void Explanation()
        {
            Console.WriteLine("Josephus Circle is a mathematical problem where many people are sitting in a circle, " +
                "and the first one in the sequence kills the second, the third kills the fourth, and so on until " +
                "only one person lives. A problem can have a step, saying the killer jumps two person, so the " +
                "first would kill the fourth, continuing until only one survives, in the case of a jump forcing a suicide, " +
                "it would jump to the next possible person, and if the jump is bigger than the people on the circle, " +
                "it continues counting until a stop.");
        }
    }
}
