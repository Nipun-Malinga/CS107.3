using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
    internal class Arrays
    {
        public int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        public void MaxValue()
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine($"The Max Value is: {max}");
        }
        public void MinValue()
        {
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine($"The Max Value is: {min}");
        }
        public void Average()
        {
            int total = 0;
            double avg;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    total = +arr[i];
                }
            }
            avg = Convert.ToDouble(total) / arr.Length;
            Console.WriteLine($"The Average Value is: {avg}");
        }
        public void Reverse() 
        {
            int temp, revCount = arr.Length;

            for (int i = 0; i < arr.Length /2; i++)
            {
                temp = arr[i];
                arr[i] = arr[revCount - 1];
                arr[revCount - 1] = temp;
                revCount--;
            }
            Console.Write("Reverse order of the array: ");
            for (int i = 0; i < arr.Length;i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }
    }
}
