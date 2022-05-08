using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    public class FindNo
    {
        public int NoIsFind()
        {
            int first = 0, last = 160, mid;
            while (first != last)
            {
                mid = (first + last) / 2;
                Console.WriteLine("enter 1 if no is between" + first + "-" + mid + "\n enter 2 if no is between" + mid + "-" + last);
                int c = Convert.ToInt32(Console.ReadLine());
                mid = (first + last) / 2;
                if (c == 1)
                    last = mid;
                else
                    first = mid + 1;
            }
            return first;
        }
    }
}


