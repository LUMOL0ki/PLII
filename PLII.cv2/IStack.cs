using System;
using System.Collections.Generic;
using System.Text;

namespace PLII.cv2
{
    public interface IStack : IADT
    {
        void Push(int number);
        int Pop();
        int Top();
    }
}