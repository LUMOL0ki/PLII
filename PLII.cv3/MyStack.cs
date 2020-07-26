using System;
using System.Collections.Generic;
using System.Text;

namespace PLII.cv3
{
    public class MyStack<T> : IStack<T>
    {
        private T[] array;
        private int index;

        public MyStack(int length)
        {
            array = new T[length];
            index = 0;
        }

        public void Clear()
        {
            index = 0;
        }

        public bool IsEmpty()
        {
            return index == 0;
        }

        public bool IsFull()
        {
            return index >= array.Length - 1;
        }

        public T Pop()
        {
            if (IsEmpty())
            {
                throw new Exception("Stack is Empty");
            }
            index--;
            return array[index];
        }

        public void Push(T value)
        {
            if (IsFull())
            {
                throw new Exception("Stack is full.");
            }
            array[index] = value;
            index++;
        }

        public T Top()
        {
            return array[index];
        }

        public override string ToString()
        {
            string fullString = "";
            foreach(T value in array)
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