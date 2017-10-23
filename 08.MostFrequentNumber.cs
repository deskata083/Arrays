using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostFrequentNumber
{
    public class StartUp
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine()
              .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
              .Select(int.Parse)
              .ToArray();

            int count = 0;
            int[] result;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i; j < numbers.Length; j++)
                {
                    if (i != j)
                    {
                        if (numbers[i] == numbers[j])
                        {
                            result=numbers.Take(numbers[i]).ToArray();
                            count++;
                            break;
                        }
                    }
                }
            }
            for (int i = 0; i < result.Length; i++)
            {

            }
        }
    }
}
