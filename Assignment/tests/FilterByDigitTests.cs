using Xunit;

namespace Assignment.Tests;

public class FilterByDigitTests
{
    [Fact]
    public void FilterByDigitWorks()
    {
        Assert.Equal(
            new [] { 1, 2, 3, 4, 5, 6, 7, 68, 69,70,15,17 }.FilterByDigit(7),
            new [] { 7, 70, 17}
            );
    }
}