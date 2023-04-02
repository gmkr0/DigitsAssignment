using Xunit;

namespace Assignment.Tests;

public class FilterByPalindromicTests
{
    [Fact]
    public void FilterByPalindromicWorks()
    {
        Assert.Equal(
            new [] { 1, -1, 121, 1231, 66, 12321, -121, 45 }.FilterByPalindromic(),
            new [] { 1, -1, 121, 66, 12321, -121 }
        );
    }
}