using System;
using System.Collections.Generic;
using System.Text;

namespace PLII.cv3
{
    public class OutofSize : Exception
    {
        public OutofSize() : base("Array is already bigger.")
        {

        }

        public OutofSize(string message) : base(message)
        {

        }
    }
}
