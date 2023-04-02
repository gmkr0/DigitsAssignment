using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;

namespace Assignment;

public static class NumberExtensions
{
    public static bool ContainsDigit(this int number, int digit)
    {
        if (digit < 0 || digit > 9)
            throw new ArgumentException("Digit must be a value between 0 and 9");
        
        number = Math.Abs(number);
        
        while (number > 0)
        {
            if (number % 10 == digit) //takes the last digit of a number and checks if it equal to input digit
                return true;
            number /= 10; //removes the last digit from number
        }

        return false;  
    }

    /// <summary>
    /// The idea of the method is to check if the number is palindromic *without using strings or arrays*
    /// The algorithm:
    ///  - Create temporary int variable to store the *second* half of the number backwards
    ///  - Take the last digit of a number and 'append' it to temporary number
    ///  - Remove the last digit of a number
    ///  - Do it (numbersOfDigitsInNumber / 2) times
    ///  - If count of digits in original number is odd, we need to get rid of the last digit before the next step
    ///  - Compare two number
    /// Example:
    ///  - Input 1234321
    ///  - digitCountInNumber = 7 (is odd)
    ///  - 1st iteration -> number: 123432, temp_number: 1
    ///  - 2nd iteration -> number: 12343, temp_number: 12
    ///  - 3nd iteration -> number: 1234, temp_number: 123
    ///  - number is odd, meaning we need to get rid of last digit of number -> number: 123
    ///  - number: 123 == temp_number: 123 -> the input is palindromic
    /// </summary>
    /// <param name="number"></param>
    /// <returns></returns>
    public static bool IsPalindromic(this int number)
    {
        number = Math.Abs(number);

        if (number < 10)
            return true; //single digit numbers are palindromic

        var digitCountInNumber = DigitCount(number);
        var tempNumber = 0;

        for (var i = 0; i < digitCountInNumber / 2; i++)
        {
            tempNumber *= 10;
            tempNumber += number % 10;
            number /= 10;
        }

        if (digitCountInNumber % 2 != 0) //is even
            number /= 10; //removes digit in the middle of a original number

        return number == tempNumber;
    }

    private static int DigitCount(this int number)
    {
        if (number == 0)
            return 1;

        int i = 0;
        while (number != 0)
        {
            number /= 10;
            i++;
        }

        return i;
    }
}