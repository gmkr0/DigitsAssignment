using Xunit;

namespace Assignment.Tests;

public class IsPalindromicTests
{
    [Fact] void Test_123IsNotPalindromic() => Assert.False(123.IsPalindromic());
    [Fact] void Test_3123IsNotPalindromic() => Assert.False(3123.IsPalindromic());
    [Fact] void Test_123421IsNotPalindromic() => Assert.False(123421.IsPalindromic());
    
    [Fact] void Test_123321IsPalindromic() => Assert.True(123321.IsPalindromic());
    [Fact] void Test_12321IsPalindromic() => Assert.True(12321.IsPalindromic());
    [Fact] void Test_43334IsPalindromic() => Assert.True(43334.IsPalindromic());
    [Fact] void Test_33333IsPalindromic() => Assert.True(33333.IsPalindromic());
    [Fact] void Test_33IsPalindromic() => Assert.True(33.IsPalindromic());
    [Fact] void Test_0IsPalindromic() => Assert.True(0.IsPalindromic());
    [Fact] void Test_2IsPalindromic() => Assert.True(2.IsPalindromic());
}