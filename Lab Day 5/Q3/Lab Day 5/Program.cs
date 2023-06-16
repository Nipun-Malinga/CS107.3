using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Day_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int in1 = 0, in2 = 0, choice = 0;
            while (true)
            {
                Console.WriteLine("Enter Choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice < 0 && choice > 4)
                {
                    Console.WriteLine("Invalid Calculation!");
                    break;
                }
                Console.WriteLine("Enter Number 1: ");
                in1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Number 2: ");
                in2 = Convert.ToInt32(Console.ReadLine());

                Calculator c1 = new Calculator(choice, in1, in2);
                Console.WriteLine("The Value is" + c1.calculation());
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}
