using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHashFunction
{
    class SetElement
    { 
        public List<string> Keys { get; set; }
    }
    public class StringHashSet
    {
        private SetElement[] array;
        public StringHashSet(int capacity = 8)
        {
            array = new SetElement[capacity];        
        }

        private int HashFunction(string key)
        {
            return key[0] << 5 | key[key.Length - 1] >> 3 % array.Length;
                //Math.Abs(key.GetHashCode() % array.Length);
            //int asciiResult = key[0] << 5 | key[key.Length - 1] >> 4;
            //return asciiResult % array.Length;
        }

        public void Add(string key)
        {
            int index = HashFunction(key);
            if (array[index] != null)
            {
                array[index].Keys.Add(key);
            }
            else
            {
                array[index] = new SetElement() { Keys = new List<string>() { key } };
            }
        }
        public bool Contains(string key)
        {
            int index = HashFunction(key);

            if (array[index] != null)
            {
                for (int i = 0; i < array[index].Keys.Count; i++)
                {
                    if (array[index].Keys[i] == key)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
