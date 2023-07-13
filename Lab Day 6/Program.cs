using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Day_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Array Size: ");
            int size = int.Parse(Console.ReadLine());

            Array a1 = new Array();
            a1.setSize(size);
            a1.data();

            Console.ReadLine();
        }

    }
}
