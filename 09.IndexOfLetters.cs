namespace IndexOfLetters
{
    using System;
    using System.Linq;
    class StartUp
    {
        static void Main(string[] args)
        {
            char[] vhod = Console.ReadLine().ToLower().ToArray();
            char[] arr = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h',
                'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r' ,'s', 't' ,'u', 'v' ,'w', 'x','y', 'z' };

            for (int i = 0; i < vhod.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (vhod[i] == arr[j])
                    {
                        Console.WriteLine($"{vhod[i]} -> {j}");
                        break;
                    }
                }
            }
        }
    }
}
