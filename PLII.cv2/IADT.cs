using System;
using System.Collections.Generic;
using System.Text;

namespace PLII.cv2
{
    public interface IADT
    {
        bool IsEmpty();
        bool IsFull();
        void Clear();

        int?[] Elements { get; }
    }
}