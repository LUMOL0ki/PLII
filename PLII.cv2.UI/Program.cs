using System;

namespace PLII.cv2.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            MyQueue myQueue = new MyQueue(1);
            myQueue.Add(25);
            Console.WriteLine(myQueue.Get());
            MyStack myStack = new MyStack(1);
            myStack.Push(35);
            Console.WriteLine(myStack.Pop());
        }
    }
}
