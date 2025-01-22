namespace Studies.BigO;

public class BigOExamples
{
    /// <summary>
    /// This method calculates the sum of character codes in a string.
    /// 
    /// Big O Analysis:
    /// - First Loop:
    ///   Iterates through the string once, so the complexity is O(n).
    /// 
    /// - Second Loop:
    ///   Iterates through the string again, so the complexity is O(n).
    /// 
    /// - Combined Complexity:
    ///   Since the two loops are consecutive, we add their complexities: O(n) + O(n) = O(2n).
    ///   In Big O, constants are ignored, so the final time complexity is O(n).
    /// </summary>
    public static int SumCharCodes(string input)
    {
        int sum = 0;

        for (int i = 0; i < input.Length; i++)
        {
            sum += input[i];
        }

        for (int i = 0; i < input.Length; i++)
        {
            sum += input[i];
        }

        return sum;
    }
}