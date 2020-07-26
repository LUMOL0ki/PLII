using System;
using System.Collections;
using System.Collections.Generic;

namespace PLII.cv6.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack myStack = new MyStack(5);
            myStack.Push(54);
            myStack.Push(43);
            myStack.Push(34);
            myStack.Push(23);
            myStack.Push(14);

            Console.WriteLine("Top: " + myStack.Peek());
            
            foreach(int i in myStack)
            {
                Console.WriteLine(i);
            }

            foreach(int i in myStack.Total())
            {
                Console.WriteLine("Total: " + i);
            }

            int[] numbers = new int[9]{ 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            IComparer<int> comparer = new EvenFirst();

            Array.Sort(numbers, new OddFirst());
            foreach (int number in numbers)
            {
                Console.WriteLine("After:" + number);
            }

            Console.WriteLine("");
            Array.Sort(numbers);
            Array.Sort(numbers, comparer);
            
            foreach (int number in numbers)
            {
                Console.WriteLine("After:" + number);
            }

            int[] numbersB = new int[9] { 1, 3, 4, 11, 21, 31, 14, 54, 41 };

            Console.WriteLine("");
            Array.Sort(numbersB);
            Array.Sort(numbersB, new Decadic());

            foreach (int number in numbersB)
            {
                Console.WriteLine("After:" + number);
            }

            Console.WriteLine("");
            Array.Sort(numbersB, new ReverseDecadic());

            foreach (int number in numbersB)
            {
                Console.WriteLine("After:" + number);
            }
        }
    }
}
