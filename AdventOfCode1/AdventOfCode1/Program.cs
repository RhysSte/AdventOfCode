using System;
using System.IO;
using System.Linq;

namespace AdventOfCode1
{
    class Program
    {
        static void Main(string[] args)
        {
           // part 1 & 2
            var lines = File.ReadAllLines(@"C:\Users\rhyss\source\repos\AdventOfCode1\AdventOfCode1\Advent.txt").Select(int.Parse).ToArray();
            var counter = 0;
            var preSum = 0;

            for (var i = 1; i < lines.Length; i++)
            {
                try
                {
                    var currentWin = lines[i - 1] + lines[i] + lines[i + 1];
                    Console.WriteLine(currentWin + "current Window");

                    var nextWin = lines[i] + lines[i + 1] + lines[i + 2];
                    Console.WriteLine(nextWin + "Next Window");

                    if (nextWin > currentWin)
                    {
                        counter++;
                    }

                }
                catch
                {
                    Console.WriteLine("err oopsy josh broke it");
                }
               
            }
            Console.WriteLine(counter);


          
        }
    }
}