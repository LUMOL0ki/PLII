using System;
using System.Collections.Generic;
using System.Text;

namespace PLII.cv2
{
    public class MyQueue : IQueue
    {
        private int[] array;
        private int index;
        private int current;

        public MyQueue(int length)
        {
            array = new int[length];
            index = 0;
            current = 0;
        }

        public int?[] Elements
        {
            get
            {
                int?[] elements = new int?[array.Length];
                for (int i = current; i < index; i++)
                {
                    elements[i] = array[i];
                }
                return elements;
            }
        }

        public void Add(int number)
        {
            if (IsFull())
            {
                throw new Exception("Array length exceeded");
            }
            array[index] = number;
            index++;
        }

        public void Clear()
        {
            index = 0;
            current = 0;
        }

        public int Get()
        {
            if (IsEmpty())
            {
                throw new Exception("Array is empty.");
            }
            current++;
            return array[current - 1];
        }

        public bool IsEmpty()
        {
            return current == index;
        }

        public bool IsFull()
        {
            return index == array.Length;
        }
    }
}