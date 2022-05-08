using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    public class PrimeNo
    {
        public void IsPrime()
        {
            int num, count, i;
            Console.WriteLine("All Prime number from 0 to 1000");
            for (num = 1; num <= 1000; num++)
            {
                count = 0;
                for (i = 1; i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        count++;
                    }
                }
                if (count == 2)
                {
                    Console.WriteLine(num);
                }
            }
        }
    }
}
