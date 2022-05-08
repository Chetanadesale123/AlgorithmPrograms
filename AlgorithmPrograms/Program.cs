using AlgorithmPrograms;
using System;
class Program
{
    static void Main(String[] args)
    {
        Console.WriteLine("Welcome to Algorithm ");
        bool end = true;
        Console.WriteLine(" \n 1.Binary Search \n 2.Insertion Sort \n 3. Bubble sort \n 4.Merge Sort \n 5. Anagram program \n 6. Prime no \n 7. primePalindrome \n 8.Generic Sorting \n 9. End the Program");
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
                    MergeSort mergesort = new MergeSort();
                    int[] arr2 = { 12, 11, 13, 5, 6, 7 };
                    Console.WriteLine("Given Array");
                    mergesort.printArray(arr2);
                    mergesort.Sorting(arr2, 0, arr2.Length - 1);
                    Console.WriteLine("\nSorted array");
                    mergesort.printArray(arr2);
                    break;
                case 5:
                    AnagramDetection anagram = new AnagramDetection();
                    string wordOne = "listen";
                    string wordTwo = "silent";
                    Console.WriteLine(anagram.IsAnagram(wordOne, wordTwo));
                    break;
                case 6:
                    PrimeNo prime = new PrimeNo();
                    prime.IsPrime();
                    break;
                case 7:
                    PrimePalindrome primepali = new PrimePalindrome();
                    Console.WriteLine("Enter the lowe limit");
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the higher limit");
                    int num2 = Convert.ToInt32(Console.ReadLine());
                    primepali.PrimePalim(num1, num2);
                    break;
                case 8:
                    GenericsForSorting genericsort = new GenericsForSorting();
                    int[] arr3 = { 12, 11, 13, 5, 6, 7 };
                    float[] arr4 = { 97.9f, 6.6f, 2.14f, 14.8f, 4.5f };
                    string[] arr5 = { "cpp", "javascript", "python", "perl", "ruby" };
                    genericsort.SelectionSort<int>(arr3);
                    genericsort.SelectionSort<float>(arr4);
                    genericsort.SelectionSort<string>(arr5);
                    genericsort.BubbleSort<int>(arr3);
                    genericsort.BubbleSort<float>(arr4);
                    genericsort.BubbleSort<string>(arr5);
                    genericsort.InsertionSort<int>(arr3);
                    genericsort.InsertionSort<float>(arr4);
                    genericsort.InsertionSort<string>(arr5);
                    break;
                case 9:
                    end = false;
                    break;
                default:
                    Console.WriteLine("Enter Proper Option To Execute");
                    break;
            }
        }
    }
}

