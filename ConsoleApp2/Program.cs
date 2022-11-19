using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main()
        {
            List<GBox<int>> gBoxes = new List<GBox<int>>();

            Console.WriteLine("write number");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var some1 = new GBox<int>(int.Parse(Console.ReadLine()));
                gBoxes.Add(some1);

            }

            foreach (var some in gBoxes)
            {
                Console.WriteLine(some.ToString());
            }
        }
    }
}
