using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace aoc2021
{
    public class Support<T>{
        public static string LoadFile(string path){
            using (var sr = new StreamReader(new FileStream(path, FileMode.Open)))
            {
                return sr.ReadToEnd();
            }
        }

        public static IEnumerable<T> LoadAsLines(string path){
            if (typeof(T) == typeof(string))
                return (IEnumerable<T>)LoadFile(path).Split("\n").Select(p => p.Trim());

            if (typeof(T) == typeof(int))
                return (IEnumerable<T>)LoadFile(path).Split("\n").Select(p => int.Parse(p.Trim()));

            return null;
        }
    }
}
