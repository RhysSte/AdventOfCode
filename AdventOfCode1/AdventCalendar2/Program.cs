using System;
using System.IO;
using System.Linq;


namespace AdventCalendar2
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadAllLines(@"C:\Users\rhyss\source\repos\AdventOfCode1\AdventCalendar2\AdventCode.txt").ToArray();

            int forwardCount = 0;
            int aim = 0;
            int depth = 0;

            for (var i = 0; i < lines.Length; i++)
            {
                var parts = lines[i].Split(" ");
                var direction = parts[0];
                int value = int.Parse(parts[1]);

                switch (direction)
                {
                    case "forward":
                        forwardCount += value;
                        depth += aim * value;
                        break;
                    case "up":
                        aim -= value;
                        
                        break;
                    case "down":
                        aim += value;
                        break;
                }
            }

            var total = depth * forwardCount;

            Console.WriteLine(total);


        }
    }
}
