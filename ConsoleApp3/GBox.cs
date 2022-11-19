using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class GBox<T>
    {


        public T Some { get; set; }

        public override string ToString()
        {
            return $"{this.GetType()/*.FullName*/} : {Some}";
        }

        public GBox(T some)
        {
            Some = some;
        }

        public static void GSwap()
        {

        }
    }
}
