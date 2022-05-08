using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    public class AnagramDetection
    {
        public bool IsAnagram(string length1, string length2)
        {
            var str1 = length1.ToLower().ToArray();
            var str2 = length2.ToLower().ToArray();
            Array.Sort(str1);
            Array.Sort(str2);
            return new string(str1) == new string(str2);
        }
    }
}


