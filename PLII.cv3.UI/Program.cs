using System;

namespace PLII.cv3.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            MyQueue<int?> myQueue = new MyQueue<int?>(8);
            myQueue.Add(20);
            myQueue.Add(30);
            myQueue.Add(40);
            myQueue.Add(50);
            myQueue.Add(60);
            Console.WriteLine(myQueue);
            MyStack<int?> myStack = new MyStack<int?>(10);
            myStack.Push(35);
            myStack.Push(45);
            myStack.Push(55); 
            myStack.Push(null);
            Console.WriteLine(myStack);
        }
    }
}
