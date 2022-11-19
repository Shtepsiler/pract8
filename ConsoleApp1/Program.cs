using System;
using System.Collections.Generic;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {
            List<GBox<string>> gBoxes = new List<GBox<string>>();

            Console.WriteLine( "write number");
            int n = int.Parse( Console.ReadLine() );
            for (int i = 0; i < n; i++)
            {
                var some1 = new GBox<string>(Console.ReadLine());
            gBoxes.Add(some1);

            }

            foreach(var some in gBoxes)
            {
                Console.WriteLine( some.ToString() );
            }

        }
    }
}
