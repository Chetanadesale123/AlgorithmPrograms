using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    public class GenericsForSorting
    {
        public void BubbleSort<T>(T[] enter) where T : IComparable<T>
        {
            for (int m = 0; m < enter.Length; m++)
            {
                for (int y = 0; y < enter.Length - 1; y++)
                {
                    if (enter[y].CompareTo(enter[y + 1]) > 0)
                    {
                        T temp = enter[y + 1];
                        enter[y + 1] = enter[y];
                        enter[y] = temp;
                    }
                }
            }
            Console.WriteLine("\n after bubble sort :");
            for (int m = 0; m < enter.Length; m++)
            {
                Console.Write(enter[m] + " ");
            }
            Console.Write("\n");
        }
        public void SelectionSort<T>(T[] enter) where T : IComparable<T>
        {
            for (int x = 0; x < enter.Length; x++)
            {
                int index_of_min = x;
                for (int y = x; y < enter.Length; y++)
                {
                    if (enter[index_of_min].CompareTo(enter[y]) > 0)
                    {
                        index_of_min = y;
                    }
                }
                T temp = enter[x];
                enter[x] = enter[index_of_min];
                enter[index_of_min] = temp;
            }
            Console.WriteLine("\n after selection sort :");
            for (int x = 0; x < enter.Length; x++)
            {
                Console.Write(enter[x] + " ");
            }
            Console.Write("\n");
        }
        public void InsertionSort<T>(T[] array) where T : IComparable<T>
        {
            int i, j;
            for (i = 1; i < array.Length; i++)
            {
                T value = array[i];
                j = i - 1;
                while ((j >= 0) && (array[j].CompareTo(value) > 0))
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = value;
            }
            Console.WriteLine("\n after Insertion sort :");
            for (int x = 0; x < array.Length; x++)
            {
                Console.Write(array[x] + " ");
            }
            Console.Write("\n");
        }
    }
}

