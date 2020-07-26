using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace PLII.cv6
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

        public int Peek()
        {
            return array[array.Length-1];
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        public IEnumerable Total()
        {
            int result = 0;
            foreach(int i in this)
            {
                result += i;
                yield return result;
            }
            
        }

        public IEnumerator GetEnumerator()
        {
            return new MyStackEnum(array);
        }
    }
}