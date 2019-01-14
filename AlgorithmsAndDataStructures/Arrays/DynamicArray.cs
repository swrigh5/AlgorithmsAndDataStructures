using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndDataStructures
{
    public class DynamicArray<String>
    {
        private object[] data;
        private int size;
        private int initialCapacity;

        public DynamicArray(int initialCapacity)
        {
            this.initialCapacity = initialCapacity;
            data = new object[initialCapacity];
        }

        public int sizeOf() { return size; }

        public string Get(int index)
        {
            return (string)data[index];
        }

        public void Set(int index, string value)
        {
            data[index] = value;
        }

        public void insert(int index, string value)
        {
            //Check size
            if (size == initialCapacity)
                resize();

            //Copy Up
            for (int j = size; j > index; j--)
                data[j] = data[j - 1];

            //Insert
            data[index] = value;
            size++;


        }

        public void add(String value)
        {
            if (size == initialCapacity)
                resize();
           
            data[size] = value;
            size++;
        }

        private void resize()
        {
            object[] newData = new object[initialCapacity * 2];

            for (int i = 0; i < initialCapacity; i++)
                newData[i] = data[i];

            data = newData;
            initialCapacity = initialCapacity * 2;
        }

        public void delete(int index)
        {
            for (int j = index; j < size - 1; j++)
            {
                data[j] = data[j + 1];
                data[j + 1] = null;
            }
            
            size--;
        }

        public bool isEmpty()
        {
            return size == 0;         
        }

        public bool Contains(string value)
        {
            for (int j = 0; j < size; j++)
            {
                if (data[j] == value)
                    return true;
            }

            return false;           
        }

        public void Print()
        {

        }


        
        
    }
}
