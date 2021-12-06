using System;
using System.Linq;
using System.Text;

namespace aoc2021
{

    public class Day03 : AbstractDay
    {
        public override string Part1()
        {
            var lines = Support<string>.LoadAsLines("day03/data.txt").ToArray();
            
            var result = GetMostCommon(lines);
            var gamma = ConvertFromBinary(result);
            var epsilon = ConvertFromBinary(Invert(result));

            return $"{gamma * epsilon}";
        }

        int[] GetMostCommon(string[] lines)
        {
            var result = new StringBuilder();

            for (int j = 0; j < lines[0].Length; j++)
            {
                StringBuilder s = new StringBuilder();
                for (int i = 0; i < lines.Length; i++)
                    s.Append(lines[i][j]);

                var zeros = s.ToString().Count(p => p == '0');
                var ones = lines.Count() - zeros;

                result.Append((zeros <= ones ? '1' : '0'));
            }

            return result.ToString().Select(p => int.Parse(p.ToString())).ToArray();
        }

        int ConvertFromBinary(int[] input)
        {
            var res = 0;
            input = input.Reverse().ToArray();
            
            for(int i = 0; i < input.Length; i++)
                res = res + input[i] * (int)Math.Pow(2, i);

            return res;
        }


        int[] Invert(int[] input) => input.Select(p => p == 0 ? 1 : 0).ToArray();

        public override string Part2()
        {
            var lines = Support<string>.LoadAsLines("day03/data.txt").ToArray();
            var two = Support<string>.LoadAsLines("day03/data.txt").ToArray();
            var result = GetMostCommon(lines);

            for(int i = 0; i < result.Length; i++)
            {
                lines = lines.Where(p => p[i] == (char)(result[i] + 48)).ToArray();
            }

            return "not done";
        }
    }
}