using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace PLII.cv6
{
    public class MyStackEnum : IEnumerator
    {
        public int[] array;
        int position = -1;


        public MyStackEnum(int[] array)
        {
            this.array = array;
        }

        object IEnumerator.Current 
        {
            get
            {
                return Current;
            }
        }

        public int Current
        {
            get
            {
                try
                {
                    return array[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }

        public bool MoveNext()
        {
            position++;
            return (position < array.Length);
        }

        public void Reset()
        {
            position = -1;
        }
    }
}
