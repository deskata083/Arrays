namespace MaxSequenceOfEqualElements
{
using System;
using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int bestStart = 0;
            int bestLen = 0;
            int count = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                count = 0;
                while (numbers[i + count] == numbers[i + 1 + count]-1)
                {
                    count++;
                    if (i + 1 + count > numbers.Length - 1)
                    {
                        break;
                    }
                }
                if (count > bestLen)
                {
                    bestLen = count;
                    bestStart = i;
                }
            }
            for (int i = bestStart; i <= bestStart + bestLen; i++)
            {
                Console.Write($"{numbers[i]} ");
            }
        }
    }
}
