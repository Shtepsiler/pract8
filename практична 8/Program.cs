using System;

namespace практична_8
{
    internal class Program
    {
        static void Main()
        {

            var some1 = new GBox<int>(int.Parse(Console.ReadLine()));
            var some2 = new GBox<string>(Console.ReadLine());


            Console.WriteLine(some1.ToString());
            Console.WriteLine(some2.ToString());

        }
    }
}
