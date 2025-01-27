namespace Studies.Algorithms.Search.TwoCrystalBallsProblem;

public class TwoCrystalBalls
{
    public static int TwoCrystalBallsSolution(bool[] breaks)
    {
        // Determine the optimal jump size using the square root of the array length.
        // This helps reduce the number of checks from O(N) to O(√N).
        var jumpAmount = (int)Math.Floor(Math.Sqrt(breaks.Length));

        // Perform large jumps to find the first index where 'breaks' is true.
        int i = jumpAmount;
        for (; i < breaks.Length; i += jumpAmount)
        {
            if (breaks[i])
            {
                // Stop when a breaking point is found.
                break;
            }
        }

        // Move back one jump to start a linear search in the last safe zone.
        i -= jumpAmount;

        // Perform a linear search in the range [i, i + jumpAmount]
        // to find the exact breaking point.
        for (int j = 0; j < jumpAmount && i < breaks.Length; ++j, ++i)
        {
            if (breaks[i])
            {
                return i; // Return the exact breaking point index.
            }
        }

        return -1; // Return -1 if no breaking point is found.
    }
}