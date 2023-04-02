namespace Assignment;


/// <summary>
/// Main tasks
/// </summary>
public static class Methods
{
    public static IEnumerable<int> FilterByDigit(this IEnumerable<int> input, int digit)
    {
        if (digit < 0 || digit > 9)
            throw new ArgumentException("Digit must be a value between 0 and 9");
        
        var result = new List<int>();
    
        foreach (var number in input)
        {
            if (number.ContainsDigit(digit))
                result.Add(number);
        }

        return result;
    }

    public static IEnumerable<int> FilterByPalindromic(this IEnumerable<int> input)
    {
        var result = new List<int>();
    
        foreach (var number in input)
        {
            if (number.IsPalindromic())
                result.Add(number);
        }

        return result;
    }
}