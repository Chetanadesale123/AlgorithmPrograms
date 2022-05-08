using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    public class PrimePalindrome
    {
        public void PrimePalim(int num1, int num2)
        {
            int c, rev, temp, i, num;
            Console.WriteLine("The Prime Palindrome Numbers are :");
            for (num = num1; num <= num2; num++)
            {
                temp = num;
                c = 0;
                rev = 0;
                for (i = 1; i <= temp; i++)
                {
                    if (temp % i == 0)
                        c++;
                }
                if (c == 2)
                {
                    while (temp > 0)
                    {
                        rev = rev * 10 + (temp % 10);
                        temp = temp / 10;
                    }
                    if (rev == num)
                    {
                        Console.WriteLine(num);
                    }
                }
            }
        }
    }
}
