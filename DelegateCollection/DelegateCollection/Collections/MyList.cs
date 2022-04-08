using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateCollection.Collections
{
    public class MyList<T>
    {
        public int Capacity { get; }
        private int Count { get; set; }
        private T[] arr;
        public MyList()
        {
            arr = new T[0];
        }

        public MyList(int capacity)
        {
            Capacity = capacity;
            arr = new T[Capacity];
        }

        public void Add(T item)
        {
            Resize();
            arr[Count] = item;
            Count++;
        }

        private void Resize()
        {

            if (arr.Length == 0)
            {
                Array.Resize(ref arr, 1);
            }
            if (Count == arr.Length)
            {
                if (Capacity == 0)
                    Array.Resize(ref arr, arr.Length * 2);
                else
                    Array.Resize(ref arr, arr.Length + Capacity);
            }
        }

        public T Find(Predicate<T> predicate)
        {
            for (int i = 0; i < Count; i++)
            {
                if (predicate(arr[i]))
                {
                    return arr[i];
                }
            }
            return default;
        }
    }
}
