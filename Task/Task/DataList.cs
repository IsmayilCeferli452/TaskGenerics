using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    internal class DataList<T>
    {
        private T[] list;

        public DataList()
        {
            list = Array.Empty<T>();
        }

        public void Add(T value)
        {
            Array.Resize(ref list, list.Length + 1);
            list[list.Length - 1] = value;
        }

        public T[] Delete(T value)
        {
            for (int i = 0; i < list.Length; i++)
            {
                if (value.Equals(list[i]))
                {
                    for(int m = i; m < list.Length - 1; m++)
                    {
                        list[m] = list [m + 1];
                    }
                    list[list.Length -1 ] = default;
                }
            }
            return list;
        }

        public T[] GetAll()
        {
            return list;
        }
    }
}
