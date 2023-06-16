using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Day4
{
    internal class FindValues
    {
        public double radius;

        public void firdArea(double radius)
        {
            double area = Math.PI * radius * radius;
            Console.WriteLine("Area Of the Circle is: "+ area);
        }
        public void findCircumference(double radius) 
        { 
            double cur = 2 * Math.PI * radius;
            Console.WriteLine("Area Of the Circle is: " + cur);
        }
    }
}
