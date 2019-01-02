using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndDataStructures
{
    public class DynamicArray
    {
        private object[] data;
        private int size;
        private int initialCapacity;

        public DynamicArray(int initialCapacity)
        {
            this.initialCapacity = initialCapacity;
            data = new object[initialCapacity];
        }

        public string Get(int index)
        {
            return (string)data[index];
        }

        public void Set(int index, string value)
        {
            data[index] = value;
        }
        
    }
}
