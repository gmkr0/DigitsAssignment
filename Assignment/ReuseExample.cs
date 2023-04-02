namespace Assignment.ReuseExample;

/// <summary>
/// Example of method reuse
/// </summary>
public static class ReuseExample
{
    
    /// <summary>
    /// Filter collection using predicate
    /// </summary>
    public static IEnumerable<int> Filter(this IEnumerable<int> collection, Predicate<int> predicate)
    {
        foreach (var item in collection)
        {
            if (predicate(item))
                yield return item;
        }
    }
    
    public static IEnumerable<int> FilterByDigit(this IEnumerable<int> input, int digit)
    {
        return input.Filter(i => i.ContainsDigit(digit));
    }

    public static IEnumerable<int> FilterByPalindromic(this IEnumerable<int> input)
    {
        return input.Filter(NumberExtensions.IsPalindromic);
    }
}