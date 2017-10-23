namespace LargestCommonEnd
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            string[] firstArray = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] secondArray = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int leftCount = CommonEnd(firstArray, secondArray);
            Array.Reverse(firstArray);
            Array.Reverse(secondArray);
            int rightCount = CommonEnd(firstArray, secondArray);
            Console.WriteLine($"{Math.Max(rightCount, leftCount)}");
        }
        private static int CommonEnd(string[] fArr, string[] sArr)
        {
            int lenght = Math.Min(fArr.Length, sArr.Length);
            int count = 0;

            for (int i = 0; i < lenght; i++)
            {

                if (fArr[i] == sArr[i])
                {
                    count++;
                }
                else
                {
                    break;
                }

            }
            return count;
        }
    }
}
