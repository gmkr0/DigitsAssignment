using Xunit;

namespace Assignment.Tests;

public class ContainsDigitTests
{
    [Fact] public void Test_123Contains2() => Assert.True(123.ContainsDigit(2));
    [Fact] public void Test_123Contains1() => Assert.True(123.ContainsDigit(1));
    [Fact] public void Test_123Contains3() => Assert.True(123.ContainsDigit(3));
    [Fact] public void Test_Negative123Contains3() => Assert.True((-123).ContainsDigit(3));
    
    [Fact] public void Test_123NotContain0() => Assert.False(123.ContainsDigit(0));
    [Fact] public void Test_123NotContain4() => Assert.False(123.ContainsDigit(4));
    [Fact] public void Test_Negative123NotContain4() => Assert.False((-123).ContainsDigit(4));
}