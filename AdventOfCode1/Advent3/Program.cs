using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Advent3
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadAllLines(@"C:\Users\rhyss\source\repos\AdventOfCode1\Advent3\Code.txt").ToArray();

            List<int>gammaRate = new List<int>();

            List<int> epsilonRate = new List<int>();

            for (int i = 0; i < 12; i++)
            {
                var countOfOnes = lines.Select(line => (int)line[i]).Count(x => x == 1);
                var countOfZeros = lines.Length - countOfOnes; 

                if(countOfOnes > countOfZeros)
                {
                    gammaRate.Add(1);
                    epsilonRate.Add(0);
                }
                else
                {
                    gammaRate.Add(0);
                    epsilonRate.Add(1);
                }
                Console.WriteLine(countOfOnes);
            }

            var gammaRateStrang = string.Join("",gammaRate.Select(x => x.ToString()));

            int convertToBinary = Convert.ToInt32(gammaRateStrang, 2);

            Console.WriteLine(gammaRateStrang);
        }
    }
}