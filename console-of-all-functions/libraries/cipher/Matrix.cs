using System;

namespace console_of_all_functions.libraries.cipher
{
    class Matrix
    {
        internal static void Encode(string text)
        {
            text = text.Replace(" ", "").ToUpper();
            int root = Root(text.Length);
            if (root == 0)
            {
                Console.WriteLine("Not enough letters");
                return;
            }

            for (int i = 0; i < root; i++)
            {
                for (int j = 0; j < root; j++)
                {
                    Console.Write(text[j * root + i]);
                }
                Console.WriteLine();
            }
        }

        internal static void Decode(String text)
        {
            Encode(text);
        }

        public static int Root(int lenght)
        {
            int root = (int)Math.Sqrt(lenght);
            if (Math.Pow(root, 2) != lenght) return 0;
            else return root;
        }
    }
}