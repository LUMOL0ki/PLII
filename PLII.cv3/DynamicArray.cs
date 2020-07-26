using System;
using System.Collections.Generic;
using System.Text;

namespace PLII.cv3
{
    public enum State
    {
        Empty,
        PartialyFull,
        Full
    }

    public class DynamicArray
    {
        private int?[] array;

        public DynamicArray(int size)
        {
            this.array = new int?[size];
        }


        public int? this[int i]
        {
            get
            {
                return array[i];
            }
            set
            {
                if (array.Length <= i)
                {
                    Length = i + 1;
                }
                array[i] = value;
            }
        }

        public State State
        {
            get
            {
                State state = State.Empty;
                int valCount = 0;
                foreach (int? val in array)
                {
                    if (val.HasValue)
                    {
                        state = State.PartialyFull;
                        valCount++;
                    }
                }

                if (valCount == array.Length)
                {
                    state = State.Full;
                }
                return state;
            }
        }

        public int Length
        {
            get
            {
                return array.Length;
            }
            set
            {
                if (value >= array.Length)
                {
                    Array.Resize<int?>(ref array, value);
                }
                else
                {
                    throw new OutofSize();
                }
            }
        }

        public override string ToString()
        {
            string text = "";
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].HasValue)
                {
                    text += array[i] + "\n";
                }
                else
                {
                    text += "null\n";
                }
            }
            return text;
        }

        public void Total(out int total)
        {
            total = 0;
            foreach (int? val in array)
            {
                if (val.HasValue)
                {
                    total += (int)val;
                }
            }
        }

        public void AddTotal(ref int number)
        {
            Total(out int total);
            number += total;
        }

        public void AddToNumber(int i, ref int number)
        {
            if (array[i].HasValue)
            {
                number += (int)array[i];
            }
        }
    }
}
