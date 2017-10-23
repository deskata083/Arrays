namespace SieveОfEratosthenes
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            bool[] prime = new bool[n+1];
            for (int i = 0; i < prime.Length; i++)
            {
                prime[i] = true;
            }
            for (int i = 2; i <= Math.Sqrt(n) ; i++)
            {
                if (prime[i])
                {
                    for (int j = i*i; j < n+1; j+=i)
                    {
                        prime[j] = false;
                    }
                }
            }
            List<int> result = new List<int>();
            for (int i = 2; i < prime.Length; i++)
            {
                if (prime[i])
                {
                    result.Add(i);
                }
            }
            Console.WriteLine($" {string.Join(" ", result)}");
        }
    }
}
