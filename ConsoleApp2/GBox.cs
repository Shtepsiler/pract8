using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
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


    }
}
