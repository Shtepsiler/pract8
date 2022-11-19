using System;

namespace Custom_List
{
    internal class Program
    {
        static void Main()
        {
/*            var arr = new List<int>();

            arr.Add(1);
            arr.Add(2);
            arr.Add(3);
            arr.Add(4);
            arr.Add(5);
            arr.Add(6);
            arr.Add(7);
            arr.Add(8);
            arr.Add(9);
            arr.Add(10);
            arr.Print();
            Console.WriteLine(arr.Remove(6));
            arr.Print();
            arr.Swap(0, 8);
            arr.Print();

            Console.WriteLine(arr.CountGreaterThan(7));

            Console.WriteLine(arr.Max());
            Console.WriteLine(arr.Min());
            Console.WriteLine(arr.Contains(7));
*/

            Console.WriteLine("commands \nAdd <element> \nRemove <index> \nContains <element> \nSwap <index> <index> \nGreater <element> \nMax \nMin \nPrint \nSort asc/desc \nEND");
            var arr = new List<int>();
            string first;
            do
            {
                Console.WriteLine("Write command");
                first = Console.ReadLine();
                string[] second = first.Split(" ");


                if (second[0] == "Add")
                {
                    arr.Add(int.Parse(second[1]));
                }
                else if (second[0] == "Remove")
                {
                    arr.Remove(int.Parse(second[1]));
                }
                else if (second[0] == "Contains")
                {
                    arr.Contains(int.Parse(second[1]));
                }
                else if (second[0] == "Swap")
                {
                    arr.Swap(int.Parse(second[1]), int.Parse(second[2]));
                }
                else if (second[0] == "Greater")
                {
                    arr.CountGreaterThan(int.Parse(second[1]));
                }
                else if (second[0] == "Max")
                {
                    Console.WriteLine($"Max is {arr.Max()}");
                }
                else if (second[0] == "Min")
                {
                    Console.WriteLine($"Max is {arr.Min()}");
                }
                else if (second[0] == "Print")
                {
                    arr.Print();
                }
                else if(second[0] == "Sort")
                {
                    arr.Sort(second[1]);
                }
              

            } while (first != "END");





        }
    }
}
