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
        public void IsAnagram(string wordOne, string wordTwo)
        {
            int string1 = wordOne.Length;
            int string2 = wordTwo.Length;

            bool status = true;
            if (string1 != string2)
            {
                status = false;
            }
            else
            {
                char[] first_array = wordOne.ToLower().ToCharArray();
                char[] second_array =wordTwo.ToLower().ToCharArray();
                Array.Sort(first_array);
                Array.Sort(second_array);
                for (int i = 0; i < string1 && string1 == string2; i++)
                {
                    if (first_array[i] != second_array[i])
                    {
                        count++;
                    }
                }
            }
            if (count == 0)
            {
                Console.WriteLine(wordOne + " " + wordTwo + " " + "  word is Anagram");
            }
            else
            {
                Console.WriteLine(  " " + "word is not Anagram");
            }

        }

    }
}


