using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Day_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            animal ai = new animal();
            Console.WriteLine(ai.dog() +" "+ ai.display());
            Console.ReadLine();
        }
    }
}
