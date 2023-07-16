using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Day_08
{
    internal class Summation : SetNumbers
    {
        public Summation(int num1 , int num2)
            : base(num1, num2)
        {
            Console.WriteLine($"Summaiton of {num1} {num2} is {num1 + num2}");
        }
    }
}
