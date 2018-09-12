using System;

namespace console_of_all_functions.libraries.language
{
    class Alphabet
    {
        internal static void Letter(int letterValue)
        {
            Console.WriteLine(char.ConvertFromUtf32(letterValue + 64));
        }

        public static string ReturnLetter(int letterValue)
        {
            return char.ConvertFromUtf32(letterValue);
        }

        internal static void LetterASCII(int letterValue)
        {
            Console.WriteLine(char.ConvertFromUtf32(letterValue));
        }

        internal static void NoLineLetter(int letterValue)
        {
            Console.Write(char.ConvertFromUtf32(letterValue+64));
        }

        internal static void NoLineLetterASCII(int letterValue)
        {
            Console.Write(char.ConvertFromUtf32(letterValue));
        }

        internal static void Number(string letter)
        {
            if (letter.Length > 1)
            {
                Console.WriteLine("Parameter too long");
                return;
            }
            Console.WriteLine(char.ConvertToUtf32(letter.ToUpper(), 0) - 64);
        }

        public static int ReturnNumber(string letter)
        {
            if (letter.Length > 1)
            {
                Console.WriteLine("Parameter too long");
                return 0;
            }
            return char.ConvertToUtf32(letter.ToUpper(), 0)-64;
        }

        public static int ReturnNumber(char letter)
        {
            return char.ConvertToUtf32(char.ToUpper(letter).ToString(),0)-64;
        }

        internal static void NumberASCII(string letter)
        {
            if (letter.Length > 1)
            {
                Console.WriteLine("Parameter too long");
                return;
            }
            Console.WriteLine(char.ConvertToUtf32(letter.ToUpper(), 0));
        }

        internal static void Explanation()
        {
            Console.WriteLine("Convertions between letter and numbers.");
        }
    }
}
