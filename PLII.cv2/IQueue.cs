using System;
using System.Collections.Generic;
using System.Text;

namespace PLII.cv2
{
    public interface IQueue : IADT
    {
        void Add(int number);
        int Get();
    }
}