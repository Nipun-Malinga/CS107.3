using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Day_6
{
    internal class Array
    {
        private int size;

        public void setSize(int size)
        {
            this.size = size;
        }

        public void data()
        {
            int[] arr = new int[size];
            int[] arr2 = new int[size];
            int[] arr3 = new int[size];

            for(int i = 0; i < size; i++)
            {
                Console.Write($"Enter Array {i} Value: ");
                arr[i] = int.Parse( Console.ReadLine() );

                Console.Write($"Enter Array 2:{i} Value: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            int total = 0, total2 = 0, scalerProduct = 0;
            for(int i = 0; i < size; i++)
            {
                total =+ arr[i];
                total2 =+ arr2[i];
            }
            Console.Write($"Scaler Sum of Array 1: {total}\nScaler Sum of Array 2: {total2}");

            for(int i = 0; i < size; i++)
            {
                arr3[i] = arr[i] + arr2[i];
            }
            Console.WriteLine("\nVector Sum:");

            for (int i = 0; i < size; i++)
            {
                Console.Write($"{arr3[i]} ");
            }

            for (int i = 0; i < size; i++)
            {
                arr3[i] = arr[i] * arr2[i];
            }
            Console.Write("\nVector Product: ");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"{arr3[i]} ");
            }


            for (int i = 0; i < size; i++)
            {
                scalerProduct =+ arr3[i];
            }
            Console.Write($"\nScaler Product: {scalerProduct}");
        }
    }
}
