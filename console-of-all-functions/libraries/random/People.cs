using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_of_all_functions.libraries.random
{
    class People
    {
        internal static void List(string people)
        {
            Console.WriteLine(RandomElement(people));
        }

        protected static string RandomElement(string people)
        {
            var list = people.Split(',');
            var rand = new Random((int)DateTime.Now.Ticks%int.MaxValue);
            return list[rand.Next() % list.Length];
        }

        internal static void List(string people, int numberToChoose)
        {
            if (numberToChoose > (people.Length + 1) / 2)
            {
                Console.WriteLine("Not enough people to choose from.");
                return;
            }
            for (int i = 0; i < numberToChoose; i++)
            {
                var name = RandomElement(people);
                Console.Write(i + 1 + "º: ");
                List(name);
                people = people.Replace(name, "").Replace(",,", ",");
                people = people.StartsWith(",") ? people.Substring(1) : people;
                people = people.EndsWith(",") ? people.Substring(0,people.Length-1) : people;
            }
        }

        internal static void Explanation()
        {
            Console.WriteLine("This class can choose a number of people from a list passed to it. Use ',' to separate the names. You can pass how many you want, " +
                "but that cannot be higher than the number of people passed.");
        }
    }
}
