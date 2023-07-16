using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Day_08
{
    internal class Division : SetNumbers
    {
        public Division(int num1, int num2)
            : base(num1, num2)
        {
            Console.WriteLine($"Dvisiion of {num1} / {num2} = {num1 / num2}");
        }
    }
}
