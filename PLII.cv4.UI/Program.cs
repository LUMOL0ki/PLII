using System;
using System.Collections.Generic;

namespace PLII.cv4.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            calculator.OnSetXY += Calculator_OnSetXY;
            calculator.OnCompute += Calculator_OnCompute;
            calculator.SetXY(5, 2);
            int result = calculator.Execute((a, b) => a + b);

            int[] numbers = new int[] { 5, 20, -60, 1, 3, -4 };
            int[] positiveNumbers = Filter<int>(numbers, x => x > 0);
            foreach(int val in positiveNumbers)
            {
                Console.WriteLine(val);
            }
    }

        private static void Calculator_OnCompute(int result)
        {
            Console.WriteLine("Result: " + result);
        }

        private static void Calculator_OnSetXY(object sender, SetXYEventArgs e)
        {
            Console.WriteLine("Set: " + e.X + ", " + e.Y);
        }

        delegate bool FilterCondition<TData>(TData data);

        private static T[] Filter<T>(T[] data, FilterCondition<T> condition)
        {
            List<T> result = new List<T>();
            foreach (T val in data)
            {
                if (condition(val))
                {
                    result.Add(val);
                }
            }

            return result.ToArray();
        }
    }
}
