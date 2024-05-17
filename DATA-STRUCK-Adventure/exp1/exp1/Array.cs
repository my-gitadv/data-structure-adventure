using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exp1
{
    internal class Array
    {
        int size;
        int cap;
        int[] arr;

        public Array(int cap)
        {
            arr = new int[cap];
            this.cap = cap;
            size = 0;
        }
        public void pushBack(int value)
        {
            arr[size] = value;
            size++;
        }
        public void printAll()
        {
            Console.Write("[ ");

            for (int i = 0; i < size; i++)
            {
                Console.Write(arr[i] + ", ");
            }
            Console.Write("]");
            
        }
    }
}