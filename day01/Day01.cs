using System.Linq;

namespace aoc2021
{
    public class Day01
    {
        public object Part1(){
            var numbers = Support<int>.LoadAsLines("day01/data.txt");
            var count = 0;
            
            numbers.Aggregate(0, (p, next) => {
                if (next > p && p > 0) count++;  

                return next;
            });

            return $"The count is {count}.";
        }

        public object Execute(){
            return Part1();
            
        }
    }
}
