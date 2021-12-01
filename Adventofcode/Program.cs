using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DayOneSecond();
            DayOne();
           
        }

        private static void DayOneSecond()
        {
            var depths = File.ReadAllLines(@"..\..\..\inputDay1.txt");
            var depthsNumbers = depths.Select(x => int.Parse(x)).ToList();
            int lastMeasurement = GetSumDepth(0, depthsNumbers);
            int increments = 0;
            for (int i = 1; i < depthsNumbers.Count; i++)
            {
                if (lastMeasurement < GetSumDepth(i, depthsNumbers))
                {
                    increments++;
                }
                lastMeasurement = GetSumDepth(i, depthsNumbers);
            }
            Console.WriteLine(increments);
        }

        public static int GetSumDepth(int startIndex, List<int> depths)
        {
            if (startIndex < depths.Count - 2)
            {
                return depths[startIndex] + depths[startIndex + 1] + depths[startIndex + 2];
            }
            else if (startIndex == depths.Count - 2)
            {
                return depths[startIndex] + depths[startIndex + 1];
            }
            else
            {
                return depths[startIndex];
            }

        }

        public static void DayOne()
        {
            var depths = File.ReadAllLines(@"..\..\..\inputDay1.txt");
            var depthsNumbers = depths.Select(x => int.Parse(x)).ToList();
            int lastMeasurement = depthsNumbers[0];
            int increments = 0;
            for (int i = 1; i < depthsNumbers.Count; i++)
            {
                if (lastMeasurement < depthsNumbers[i])
                {
                    increments++;
                }
                lastMeasurement = depthsNumbers[i];
            }
            Console.WriteLine(increments);
        }
    }
}
