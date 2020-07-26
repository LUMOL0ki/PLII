using System;
using System.Collections.Generic;
using System.Text;

namespace PLII.cv4
{
    public delegate int Operation(int a, int b);
    public delegate void Computed(int result);

    public class Calculator
    { 
        public event Computed OnCompute;
        public event EventHandler<SetXYEventArgs> OnSetXY;

        private int X
        {
            get;
            set;
        }

        private int Y
        {
            get;
            set;
        }

        public void SetXY(int x, int y)
        {
            X = x;
            Y = y;
            OnSetXY?.Invoke(this, new SetXYEventArgs() { X = x, Y = y });
        }

        public int Execute(Operation operation)
        {
            int result = operation(X, Y);
            OnCompute?.Invoke(result);
            return result;
        }
    }
}
