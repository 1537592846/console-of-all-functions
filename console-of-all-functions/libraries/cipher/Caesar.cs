using System;

namespace console_of_all_functions.libraries.cipher
{
    class Caesar
    {
        internal static void Encode(string text, int jump)
        {
            foreach (char letter in text)
            {
                Console.Write(CipherLetter(letter, jump));
            }
        }

        internal static void Decode(string text, int jump)
        {
            foreach (char letter in text)
            {
                Console.Write(CipherLetter(letter, 26-jump));
            }
        }

        static char CipherLetter(char letter,int jump)
        {
            if (!char.IsLetter(letter)) return letter;
            int letterValue = Convert.ToInt32(char.ToUpper(letter))+jump;
            return Convert.ToChar(65 + ((letterValue-65) % 26));
        }
    }
}
