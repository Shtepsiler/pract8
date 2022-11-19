using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Custom_List
{
    /*class ListEnumerator<T> : IEnumerator<object>
    {
        T[] data;
        int position = -1;
        public ListEnumerator(T[] data) => this.data = data;
        public object Current
        {
            get
            {
                if (position == -1 || position >= data.Length)
                    throw new ArgumentException();
                return data[position];
            }
        }
        public bool MoveNext()
        {
            if (position < data.Length - 1)
            {
                position++;
                return true;
            }
            else
                return false;
        }
        public void Reset() => position = -1;
        void IDisposable.Dispose()
        {

        }
    }*/
    internal class List<T> where T : IComparable<T>//, IEnumerator<T>
    
    {

        int capasity = 8;

        int size = 0;
        private T[] data;
        public List()
            {
        data = new T[capasity];
            }


    //  public IEnumerator<T> GetEnumerator() => new ListEnumerator(data);
       

        public int Size { get { return size; } }

        public int Capasity { get { return capasity; } }
        public void Add(T el)
        {   
            data[size] = el;
            size++;
          

            if (size == capasity)
            {
                capasity = capasity + 8;
                T[] resized = new T[capasity];
                for (int i = 0; i < capasity-8; i++)
                {
                    resized[i] = data[i];
                }
                data = resized;

            }
        }

        public T Remove(int index)
        {
          T elem = data[index];
            T[] resized = new T[capasity];
            for (int i = 0; i < size; i++)
            {
                if (i < index)
                {
                    resized[i]= data[i];
                }
                else 
                if(i > index-1)
                {
                    resized[i] = data[i+1];
                }

            }
            data = resized;
            size--;  
            return elem;
        }

        public void Print()
        {
            for (int i = 0; i < size; i++)
                Console.Write($"{data[i]} ");
            Console.WriteLine();
        }

        public void Swap(int index1,int index2)
        {
            T first = data[index1];
            data[index1] = data[index2];
            data[index2] = first;

        }

        public bool Contains(T element)
        {
            bool count = false;

            for (int i = 0; i < size; i++)
            {
                if (element.CompareTo(data[i]) == 0)
                {
                    count= true;
                }

            }
            return count;

        }


        public int CountGreaterThan(T element)
        {
            int count = 0;

            for(int i = 0; i < size; i++)
            {
                if (element.CompareTo(data[i]) < 0)
                {
                    count++;
                }

            }
            return count;
        }

        public T Max()
        {
            T max=data[0];
            
            for(int i = 0; i < size; i++)
            {
                if(max.CompareTo(data[i]) < 0)
                {
                max = data[i];

                }
            }

            return max;


        }
        public T Min()
        {
            T min = data[0];

            for (int i = 0; i < size; i++)
            {
                if (min.CompareTo(data[i]) > 0)
                {
                    min = data[i];

                }
            }

            return min;


        }

        public void Sort(string how = "asc")
        {
            if(how == "desc")
            {
                for (int i = 0; i < size; i++)
                    for (int j = 0; j < size; j++)
                    {
                        if (data[i].CompareTo(data[j]) > 0)
                        {
                            this.Swap(i, j);

                        }
                    }
            }
            
            else {
                
                for (int i = 0; i < size; i++)
                    for(int j = 0; j < size; j++)
                {
                    if (data[i].CompareTo(data[j]) < 0)
                    {
                            this.Swap(i, j);

                    }
                }

            }
        }

    }
}
