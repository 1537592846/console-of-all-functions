using console_of_all_functions.libraries.language;
using System;

namespace console_of_all_functions.libraries.cipher
{
    class Caesar
    {
        internal static void Encode(string text, int jump)
        {
            foreach (char letter in text)
            {
                CipherLetter(letter, jump);
            }
        }

        internal static void Decode(string text, int jump)
        {
            foreach (char letter in text)
            {
                CipherLetter(letter, -1 * jump);
            }
        }

        static void CipherLetter(char letter, int jump)
        {
            if (!char.IsLetter(letter)) return;
            jump = jump % 26;
            int letterValue = Convert.ToInt32(char.ToUpper(letter)) + jump;
            Alphabet.NoLineLetterASCII((26+letterValue - 65) % 26 + 65);
        }
    }
}
