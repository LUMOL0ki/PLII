using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace PLII.cv6
{
    public interface IStack : IADT, IEnumerable
    {
        void Push(int number);
        int Pop();
        int Top();
        int Peek();
    }
}