using console_of_all_functions.libraries.language;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_of_all_functions.libraries.cipher
{
    public class Vigenere
    {
        internal static void Encode(string text, string word)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsWhiteSpace(text[i])) Console.Write(" ");
                else Alphabet.NoLineLetter(Alphabet.ReturnNumber(text[i]) + Alphabet.ReturnNumber(word[i % word.Length]) - 1);
            }
        }

        internal static void Decode(string text, string word)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsWhiteSpace(text[i])) Console.Write(" ");
                else Alphabet.NoLineLetter(Alphabet.ReturnNumber(text[i])-Alphabet.ReturnNumber(word[i%word.Length])+1);
            }
        }
    }
}