using console_of_all_functions.libraries.language;
using System;

namespace console_of_all_functions.libraries.cipher
{
    public class Vigenere
    {
        internal static void Encode(string text, string word)
        {
            var count = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (!char.IsLetter(text[i])) Console.Write(text[i]);
                else
                {
                    Alphabet.WriteLetterNoLine((Alphabet.ReturnNumber(text[i]) + Alphabet.ReturnNumber(word[count % word.Length]) - 1) % 26);
                    count++;
                }
            }
        }

        internal static void Decode(string text, string word)
        {
            var count = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (!char.IsLetter(text[i])) Console.Write(text[i]);
                else
                {
                    Alphabet.WriteLetterNoLine((26+Alphabet.ReturnNumber(text[i]) - Alphabet.ReturnNumber(word[count % word.Length]) + 1)%26);
                    count++;
                }
            }
        }
    }
}