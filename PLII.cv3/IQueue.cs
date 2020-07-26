using System;
using System.Collections.Generic;
using System.Text;

namespace PLII.cv3
{
    public interface IQueue<T> : IADT<T>
    {
        void Add(T value);
        T Get();
    }
}