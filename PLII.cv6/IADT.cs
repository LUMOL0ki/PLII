using System;
using System.Collections.Generic;
using System.Text;

namespace PLII.cv6
{
    public interface IADT
    {
        bool IsEmpty();
        bool IsFull();
        void Clear();

        int?[] Elements { get; }
    }
}