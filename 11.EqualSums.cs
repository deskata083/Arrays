namespace EqualSums
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

            bool isEqual = false;
            for (int i = 0; i < numbers.Length; i++)
            {
                int[] numbersLeft = numbers.Take(i).ToArray();
                int[] numbersRight = numbers.Skip(i + 1).ToArray();
                if (numbersLeft.Sum()==numbersRight.Sum())
                {
                    isEqual = true;
                    Console.WriteLine(i);
                    break;
                }
            }
            if (isEqual == false)
            {
                Console.WriteLine("no");
            }
        }
    }
}
