namespace RotateAndSum
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

            int k = numbers.Length / 4;
            int[] leftArr = numbers.Take(k).ToArray();
            int[] midArr = numbers.Skip(k).Take(2 * k).ToArray();
            int[] rightArr = numbers.Skip(3 * k).Take(k).ToArray();

            Array.Reverse(leftArr);
            Array.Reverse(rightArr);
            int [] result = new int[k * 2];
            for (int i = 0; i < k ; i++)
            {
                result[i] = midArr[i] + leftArr[i];
                result[i + k] = midArr[i + k] + rightArr[i];
            }
            Console.WriteLine($"{string.Join(" ",result)}");
        }
    }
}
