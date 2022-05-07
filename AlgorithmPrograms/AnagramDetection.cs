using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    public class AnagramDetection
    {
        int count = 0;
        public void IsAnagram(string firstWord, string secondWord)
        {
            int first_Length = firstWord.Length;
            int second_Length = secondWord.Length;

            bool status = true;
            if (first_Length != second_Length)
            {
                status = false;
            }
            else
            {
                char[] first_array = firstWord.ToLower().ToCharArray();
                char[] second_array = secondWord.ToLower().ToCharArray();
                Array.Sort(first_array);
                Array.Sort(second_array);
                for (int i = 0; i < first_Length && first_Length == second_Length; i++)
                {
                    if (first_array[i] != second_array[i])
                    {
                        count++;
                    }
                }
            }
            if (count == 0)
            {
                Console.WriteLine(firstWord + " " + "and" + " " + secondWord + " " + "  word is Anagram");
            }
            else
            {
                Console.WriteLine(firstWord + " " + "and" + " " + secondWord + " " + "word is not Anagram");
            }

        }

    }
}


