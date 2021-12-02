using System;
using System.Collections.Generic;
using System.Linq;

namespace aoc2021
{
    public class Day01 : AbstractDay
    {
        public override string Part1()
        {
            var numbers = Support<int>.LoadAsLines("day01/data.txt");
            var count = GetCount(numbers);

            return $"The count is {count}.";
        }

        public override string Part2()
        {
            var numbers = Support<int>.LoadAsLines("day01/data.txt").ToArray();
            var groups = new List<Group>();

            for (int i = 0; i < numbers.Count(); i++)
            {
                try
                {
                    groups.Add(new Group(numbers[i], numbers[i + 1], numbers[i + 2]));
                }
                catch
                {
                    break;
                }
            }

            var count = GetCount(groups.Select(p => p.Sum));

            return $"The count is {count}.";
        }

        int GetCount(IEnumerable<int> input)
        {
            var count = 0;

            input.Aggregate(0, (p, next) =>
            {
                if (next > p && p > 0) count++;

                return next;
            });

            return count;
        }

        class Group{
            public Group(int x, int y, int z)
            {
                Numbers = new int[3] { x, y, z};
            }
            public int[] Numbers { get;set;}

            public int Sum{
                get
                {
                    return Numbers.Aggregate(0, (prev, next) => prev + next);
                }
            }
        }
    }
}
