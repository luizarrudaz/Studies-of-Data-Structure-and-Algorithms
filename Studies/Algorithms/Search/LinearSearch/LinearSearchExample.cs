namespace Studies.Algorithms.Search.LinearSearch;

public class LinearSearchExample
{
    public static bool Linear_Search(int[] haystack, int neddle)
    {
        for (int i = 0; i < haystack.Length; i++)
        {
            if (haystack[i] == neddle)
            {
                return true;
            }
        }
        return false;
    }
}
