using System;

namespace console_of_all_functions.libraries.language
{
    class Alphabet
    {
        //Alphabet letters
        internal static char ReturnLetterChar(int letterValue)
        {
            return ReturnLetter(letterValue)[0];
        }

        internal static string ReturnLetter(int letterValue)
        {
            if (letterValue == 0) letterValue = 26;
            return char.ConvertFromUtf32(letterValue + 64);
        }

        internal static void WriteLetter(int letterValue)
        {
            if (letterValue == 0) letterValue = 26;
            Console.WriteLine(char.ConvertFromUtf32(letterValue + 64));
        }

        internal static void WriteLetterNoLine(int letterValue)
        {
            if (letterValue == 0) letterValue = 26;
            Console.Write(char.ConvertFromUtf32(letterValue + 64));
        }

        //ASCII Letters
        internal static char ReturnASCIIChar(int letterValue)
        {
            return ReturnASCII(letterValue)[0];
        }

        internal static string ReturnASCII(int letterValue)
        {
            return char.ConvertFromUtf32(letterValue);
        }

        internal static void WriteASCII(int letterValue)
        {
            Console.WriteLine(char.ConvertFromUtf32(letterValue));
        }

        internal static void WriteASCIINoLine(int letterValue)
        {
            Console.Write(char.ConvertFromUtf32(letterValue));
        }

        //Alphabet value
        internal static int ReturnNumber(char letter)
        {
            return ReturnNumber(letter.ToString());
        }

        internal static int ReturnNumber(string letter)
        {
            return char.ConvertToUtf32(letter.ToUpper(), 0) - 64);
        }

        internal static void WriteNumber(string letter)
        {
            if (letter.Length > 1)
            {
                Console.WriteLine("Parameter too long");
                return;
            }
            Console.WriteLine(char.ConvertToUtf32(letter.ToUpper(), 0) - 64);
        }

        internal static void WriteNumberNoLine(string letter)
        {
            if (letter.Length > 1)
            {
                Console.Write("Parameter too long");
                return;
            }
            Console.Write(char.ConvertToUtf32(letter.ToUpper(), 0) - 64);
        }

        //ASCII value
        internal static int ReturnNumberASCII(char letter)
        {
            return ReturnNumber(letter.ToString());
        }

        internal static int ReturnNumberASCII(string letter)
        {
            return char.ConvertToUtf32(letter.ToUpper(), 0);
        }

        internal static void WriteNumberASCII(string letter)
        {
            if (letter.Length > 1)
            {
                Console.WriteLine("Parameter too long");
                return;
            }
            Console.WriteLine(char.ConvertToUtf32(letter.ToUpper(), 0));
        }

        internal static void WriteNumberASCIINoLine(string letter)
        {
            if (letter.Length > 1)
            {
                Console.Write("Parameter too long");
                return;
            }
            Console.Write(char.ConvertToUtf32(letter.ToUpper(), 0));
        }

        internal static void Explanation()
        {
            Console.WriteLine("Convertions between letter and numbers.");
        }
    }
}
