using System;
using System.Collections.Generic;
using System.Text;

namespace PLII.cv2
{
    public class MyStack : IStack
    {
        private int[] array;
        private int index;

        public MyStack(int length)
        {
            array = new int[length];
            index = 0;
        }

        public int?[] Elements
        {
            get
            {
                int?[] elements = new int?[array.Length];
                for(int i = 0; i < index; i++)
                {
                    elements[i] = array[i];
                }
                return elements;
            }
        }


        public void Clear()
        {
            index = 0;
        }

        public bool IsEmpty()
        {
            return index <= 0;
        }

        public bool IsFull()
        {
            return index == array.Length;
        }

        public int Pop()
        {
            if (IsEmpty())
            {
                throw new Exception("Array is Empty");
            }
            index--;
            return array[index];
        }

        public void Push(int number)
        {
            if (IsFull())
            {
                throw new Exception("Array length exceeded");
            }
            array[index] = number;
            index++;
        }

        public int Top()
        {
            return array[index];
        }
    }
}