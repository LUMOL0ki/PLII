using System;
using System.Collections.Generic;
using System.Text;

namespace PLII.cv3
{
    public interface IStack<T> : IADT<T>
    {
        void Push(T value);
        T Pop();
        T Top();
    }
}