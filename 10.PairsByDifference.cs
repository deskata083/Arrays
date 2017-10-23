using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairsByDifference
{
   public class StartUp
    {
       public static void Main()
        {
            int[] vhod = Console.ReadLine()
                .Split(new char[] {' ' },StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int number = int.Parse(Console.ReadLine());
            int count = 0;
            
            for (int i = 0; i < vhod.Length; i++)
            {
                for (int j = i+1; j < vhod.Length; j++)
                {
                    if (Math.Abs(vhod[i] - vhod[j]) == number)
                    {
                        count++;
                        break;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
