using System;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        char[] arr1 = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(char.Parse)
            .ToArray();
        char[] arr2 = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(char.Parse)
            .ToArray();

        if (arr1.Length != arr2.Length)
        {
            if (arr1[0] == arr2[0])
            {
                if (arr1.Length < arr2.Length)
                {
                    Console.WriteLine($"{string.Join("", arr1)}");
                    Console.WriteLine($"{string.Join("", arr2)}");
                }
                else
                {
                    Console.WriteLine($"{string.Join("", arr2)}");
                    Console.WriteLine($"{string.Join("", arr1)}");
                }
            }
            else
            {
                if (arr1[0] < arr2[0])
                {
                    Console.WriteLine($"{string.Join("", arr1)}");
                    Console.WriteLine($"{string.Join("", arr2)}");
                }
                else
                {
                    Console.WriteLine($"{string.Join("", arr2)}");
                    Console.WriteLine($"{string.Join("", arr1)}");
                }
            }
        }
        else
        {
            int count = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] == arr2[i])
                {
                    count++;
                }
            }
            if (count == arr1.Length)
            {
                Console.WriteLine($"{string.Join("", arr1)}\r\n{string.Join("", arr1)}");
            }
            else
            {
                if (arr1[0] < arr2[0])
                {
                    Console.WriteLine($"{string.Join("", arr1)}\r\n{string.Join("", arr2)}");
                }
                else
                {
                    Console.WriteLine($"{string.Join("", arr2)}\r\n{string.Join("", arr1)}");
                }
            }
        }
    }
}



