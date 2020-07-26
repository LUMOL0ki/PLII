using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace PLII.cv6
{
    public class EvenFirst : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            return (x % 2).CompareTo(y % 2);
        }
    }

    public class OddFirst : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            return (y % 2).CompareTo(x % 2);
        }
    }

    public class Decadic : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            return (x % 10).CompareTo(y % 10);
        }
    }

    public class ReverseDecadic : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            return (-x % 10).CompareTo(y % 10);
        }
    }

}
