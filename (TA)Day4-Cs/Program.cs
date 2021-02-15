using System;

namespace _TA_Day4_Cs
{
    class Program
    {
        static void Main(string[] args)
        {


            var sum = 0;
            for (var idx = 1; idx <= 70; idx++)
            {
                if (idx % 7 == 0)
                {
                    sum += idx;
                }
            }
            Console.WriteLine($"total of nbrs divisible by 7: {sum}");
        }
    }
}
