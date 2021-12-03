using System;
using System.Net;
using System.Net.Http;

namespace AdventOfCode
{
    public class Day1
    {
        private string input;

        public void run()
        {
            Console.WriteLine("from day1");

            string[] lines = System.IO.File.ReadAllLines(@"/Users/p.nelson/repos/github/2021-advent-of-code/AdventOfCode/AdventOfCode/day1_input.txt");
            int increased = 0;
            for(int i = 1; i < lines.Length; i++)
            {
                if (int.Parse(lines[i]) > int.Parse(lines[i - 1]))
                {
                    increased++;
                }
            }
            Console.WriteLine(increased);
        }
    }
}