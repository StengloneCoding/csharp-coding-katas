using System.Diagnostics.Metrics;

namespace CodingKatas.Arrays;
public class TopKFrequent
{
    public int[] GetTopKFrequent(int[] numbers, int k)
    {
        Dictionary<int, int> countedNumbers = [];
        foreach (int number in numbers)
        {
            countedNumbers[number] = countedNumbers.GetValueOrDefault(number) + 1;
        }
        return countedNumbers.OrderByDescending(x => x.Value).Take(k).Select(x => x.Key).ToArray();
    }
}
