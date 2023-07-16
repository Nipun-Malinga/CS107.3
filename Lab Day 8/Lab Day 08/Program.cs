using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Day_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter another Number");
            int num2 = int.Parse(Console.ReadLine());

            var sum = new Summation(num1, num2);
            var sub = new Substraction(num1, num2);
            var mul = new Multiplication(num1, num2);
            var Div = new Division(num1, num2);
            Console.ReadLine();
        }
    }
}
