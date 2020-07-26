using System;
using System.Collections.Generic;
using System.Text;

namespace PLII.cv3
{
    public class MyQueue<T> : IQueue<T>
    {
        private T[] array;
        private int index;
        private int current;

        public MyQueue(int length)
        {
            array = new T[length];
            index = 0;
            current = 0;
        }
        
        public void Add(T value)
        {
            if (IsFull())
            {
                throw new Exception("Queue is Full");
            }
            array[index] = value;
            index++;
        }

        public void Clear()
        {
            index = 0;
            current = 0;
        }

        public T Get()
        {
            if (IsEmpty())
            {
                throw new Exception("Queue is empty.");
            }
            else
            {
                current++;
                return array[current-1];
            }
        }

        public bool IsEmpty()
        {
            return current == index;
        }

        public bool IsFull()
        {
            return index >= array.Length;
        }

        public override string ToString()
        {
            string fullString = "";
            foreach (T value in array)
            {
                if (value.Equals(null))
                {
                    fullString += "null\n";
                }
                else
                {
                    fullString += value.ToString() + "\n";
                }
            }
            return fullString;
        }
    }
}