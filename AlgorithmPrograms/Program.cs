using AlgorithmPrograms;
using System;
class Program
{
    static void Main(String[] args)
    {
        Console.WriteLine("Welcome to Algorithm ");
        bool end = true;
        Console.WriteLine("1. Binary Search \n 2.Insertion Sort \n 3. Bubble sort \n 4. End the Program");
        while (end == true)
        {
            Console.WriteLine("Take an option to execute :");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    const string FILE_PATH = @"R:\Practice_problem_Bridgelabz\Algorithm\Utility\List.txt ";
                    string words = File.ReadAllText(FILE_PATH);
                    string[] arr = words.Split(',');
                    Console.WriteLine("Enter a words to search");
                    string x = Console.ReadLine();
                    BinarySearch search = new BinarySearch();
                    int result = search.binarySearch(arr, x);
                    if (result == -1)
                        Console.WriteLine("Element not present");
                    else
                        Console.WriteLine("Element found at " + "index " + result);
                    break;
                case 2:
                    InsertionSort sort = new InsertionSort();
                    sort.Insertion();
                    break;
                case 3:
                    BubbleSort bubblesort = new BubbleSort();
                    bubblesort.Bubble_sort();
                    break;
                case 4:
                    end = false;
                    break;
                default:
                    Console.WriteLine("Enter Proper Option To Execute");
                    break;
            }
        }
    }
}

