using System;
using System.Linq;

namespace aoc2021
{
    public abstract class AbstractDay
    {
        public abstract string Part1();
        
        public abstract string Part2();

        public virtual string Execute()
        {
            var type = this.GetType().Name;
            return $"{type} - {Part1()}\r\n{type} - {Part2()}";
        }
    }
}
