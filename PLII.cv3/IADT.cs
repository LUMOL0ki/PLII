using System;
using System.Collections.Generic;
using System.Text;

namespace PLII.cv3
{
    public interface IADT<T>
    {
        bool IsEmpty();
        bool IsFull();
        void Clear();
    }
}