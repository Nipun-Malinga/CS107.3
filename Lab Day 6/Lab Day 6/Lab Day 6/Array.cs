using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Day_6
{
    internal class Array
    {
        private int Size;

        public Array(int size)
        {
            this.Size = size;
        }
        public void setArray()
        {
            int[] arr = new int[Size];

            for(int i = 0; i < Size; i++)
            {
                Console.Write($"Enter Value for index {i}: ");
                arr[i] = int.Parse( Console.ReadLine());
            }

            Console.WriteLine("\nDisplaying The Array: \n");

            for (int i = 0; i < Size; i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }
             
    }
}
