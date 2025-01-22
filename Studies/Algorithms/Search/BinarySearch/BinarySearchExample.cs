namespace Studies.Algorithms.Search.BinarySearch;
public class BinarySearchExample
{
    public static int Binary_Search(int[] arr, int valueToFind)
    {
        // Define the initial bounds of the array: the left index (first element)...
        int left = 0;
        // ...and the right index (last element).
        int right = arr.Length - 1;

        // Loop that continues as long as the interval between 'left' and 'right' is valid
        while (left <= right)
        {
            // Calculate the index of the middle element in the current range
            // Formula: mid = left + (right - left) / 2
            // This prevents integer overflow for very large values.
            int mid = left + (right - left) / 2;

            // Base case: check if the middle value is the one we're looking for
            if (arr[mid] == valueToFind)
            {
                return mid; // Return the index of the found value
            }

            // If the middle value is less than the target value,
            // adjust the left bound to search the right half of the array
            if (arr[mid] < valueToFind)
            {
                left = mid + 1; // Ignore the left half
            }
            else
            {
                // If the middle value is greater than the target value,
                // adjust the right bound to search the left half of the array
                right = mid - 1; // Ignore the right half
            }
        }

        // If the value is not found in the array, return -1
        return -1;
    }
}