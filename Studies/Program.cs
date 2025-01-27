using Studies.Algorithms.Search.BinarySearch;
using Studies.Algorithms.Search.LinearSearch;
using Studies.Algorithms.Search.TwoCrystalBallsProblem;
using Studies.Algorithms.Sorting.BubbleSort;
using Studies.BigO;

namespace Studies;
public class Program
{
    public static void Main(string[] args)
    {
        // Big O Example
        Console.Write("Big O: ");
        Console.WriteLine(BigOExamples.SumCharCodes("something"));
        Console.WriteLine("------------------------------------------------------");

        // Array Example
        Console.WriteLine("Array:");
        int[] numbers = { 1, 2, 3, 4, 5 };

        // Accessing elements in the array
        Console.WriteLine("First element: " + numbers[0]);
        Console.WriteLine("Last element: " + numbers[numbers.Length - 1]);

        // Iterating over the array
        Console.Write("All elements in the array: ");
        //foreach (int number in numbers)
        //{
        //    Console.WriteLine(number);
        //}
        Console.WriteLine(string.Join(", ", numbers));
        Console.WriteLine("------------------------------------------------------");

        // Linear Search
        Console.Write("Linear Search: ");
        int[] haystack = { 1, 8, 15, 18, 32 };
        int needle = 16;

        Console.WriteLine(LinearSearchExample.Linear_Search(haystack, needle));
        Console.WriteLine("------------------------------------------------------");

        // Binary Search
        Console.Write("Binary Search: ");
        int[] binary = { 1, 2, 3, 4, 5, 6, 7 };
        //int[] binary= Enumerable.Range(1, 10000).ToArray();

        int valueToFind = 4;

        Console.WriteLine(BinarySearchExample.Binary_Search(binary, valueToFind));
        Console.WriteLine("------------------------------------------------------");

        // Two Crystal Balls Problem
        Console.WriteLine("Two Crystal Balls Problem:");

        bool[] breaks = new bool[100];

        for (int i = 75; i < breaks.Length; i++)
        {
            breaks[i] = true;
        }

        int result = TwoCrystalBalls.TwoCrystalBallsSolution(breaks);
        Console.WriteLine($"Breaking Point Found at Index: {result}");
        Console.WriteLine("------------------------------------------------------");

        // Bubble Sort
        Console.WriteLine("Bubble Sort:");

        int[] arr = { 1, 4, 0, 5, 9, 7, 2, 3, 6, 8 };

        Console.Write("Array before sorting: ");
        Console.WriteLine(string.Join(", ", arr));

        BubbleSortExample.Bubble_Sort(arr);

        Console.Write("Array after sorting: ");
        Console.WriteLine(string.Join(", ", arr));
        Console.WriteLine("------------------------------------------------------");

    }
}
