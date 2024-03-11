using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    internal class IntList
    {
        private int[] list;

        public IntList()
        {
            list = Array.Empty<int>();
        }

        public void Add(int value)
        {
            Array.Resize(ref list, list.Length + 1);
            list[list.Length - 1] = value;
        }

        public int[] GetAll()
        {
            return list;
        }
    }
}
