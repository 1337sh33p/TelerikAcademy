using System;

namespace IndexOfLetters
{
    class Program
    {
        public static void IndexLettersOfWord(char[] alphabet, string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                Console.WriteLine(Array.IndexOf(alphabet, word[i])); 
            }
        }

        static void Main()
        {
            char[] alphabet = new char[123 - 97];

            for (int i = 0; i < 26; i++)
            {
                alphabet[i] = (char)(i + 97);
            }
            
            string word = Console.ReadLine();

            IndexLettersOfWord(alphabet, word);
        }
    }
}
