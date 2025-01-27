namespace Studies.Algorithms.Sorting.BubbleSort;

public class BubbleSortExample
{
    public static int[] Bubble_Sort(int[] arr)
    {
        // Outer loop iterates over the entire array
        // Each pass bubbles up the largest element to the correct position
        for (int i = 0; i < arr.Length; i++)
        {
            // Inner loop compares adjacent elements and swaps them if they are in the wrong order
            // We reduce the number of comparisons after each pass since the last elements are already sorted
            for (int j = 0; j < arr.Length - 1 - i; j++)
            {
                // If the current element is greater than the next one, swap them
                if (arr[j] > arr[j + 1])
                {
                    // Temporary variable to hold the value during the swap
                    var aux = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = aux;
                }
            }
        }

        return arr;
    }
}
