using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    public static class Day2
    {

        public static void First()
        {
            var moves = File.ReadAllLines(@"..\..\..\inputDay2.txt");
            
            var depth = 0;
            var horizontal = 0;
            foreach (var line in moves)
            {
                var split = line.Split(' ');
                if (split[0] == "down")
                {
                    depth += int.Parse(split[1]);
                }
                else if (split[0] == "up")
                {
                    depth -= int.Parse(split[1]);
                }
                else
                {
                    horizontal += int.Parse(split[1]);
                }
            }

            var result = depth * horizontal;


        }

        public static void Second()
        {
            var moves = File.ReadAllLines(@"..\..\..\inputDay2.txt");

            var depth = 0;
            var horizontal = 0;
            var aim = 0;
            foreach (var line in moves)
            {
                var split = line.Split(' ');
                if (split[0] == "down")
                {
                    aim += int.Parse(split[1]);
                }
                else if (split[0] == "up")
                {
                    aim -= int.Parse(split[1]);
                }
                else
                {
                    horizontal += int.Parse(split[1]);
                    depth += int.Parse(split[1]) * aim;
                }
            }

            var result = depth * horizontal;


        2}
    }
}
