using System;

namespace aoc2021
{
    public class Day02 : AbstractDay
    {
        public override string Part1()
        {
            var h = 0;
            var v = 0;

            var lines = Support<string>.LoadAsLines("day02/data.txt");

            foreach (var line in lines)
            {
                var parts = line.Split(' ');
                var val = int.Parse(parts[1]);
                switch (parts[0])
                {
                    case "forward":
                        h = h + val;
                        break;
                    case "down":
                        v = v + val;
                        break;
                    case "up":
                        v = v - val;
                        break;
                }
            }

            return $"{h} x {v} = {h * v}";
        }

        public override string Part2()
        {
            var h = 0;
            var v = 0;
            var aim = 0;

            var lines = Support<string>.LoadAsLines("day02/data.txt");

            foreach (var line in lines)
            {
                var parts = line.Split(' ');
                var val = int.Parse(parts[1]);
                switch (parts[0])
                {
                    case "forward":
                        h = h + val;
                        v = v + (aim * val);
                        break;
                    case "down":
                        aim = aim + val;
                        break;
                    case "up":
                        aim = aim - val;
                        break;
                }
            }

            return $"{h} x {v} = {h * v}";

 
        }
    }
}