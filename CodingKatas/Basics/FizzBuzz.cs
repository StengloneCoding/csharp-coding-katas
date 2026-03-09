namespace CodingKatas.Basics;

public class FizzBuzz
{
    public string GetFizzBuzzNumber(int number)
    {
        string result = "";
        if (number % 3 == 0) result += "Fizz";
        if (number % 5 == 0) result += "Buzz";

        return string.IsNullOrEmpty(result) ? number.ToString() : result;
    }
}
