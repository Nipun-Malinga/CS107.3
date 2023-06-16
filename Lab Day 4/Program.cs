using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Day4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Q1
            ConvertValues convertValues = new ConvertValues();
            convertValues.kmToM();
            Console.ReadLine();*/

            /*
             Q2
             
            ConvertValues convertValues = new ConvertValues();
            convertValues.kmToM(4);
            Console.ReadLine();*/
            
            /*
             Q3
            ConvertValues convertValues = new ConvertValues();
            Console.WriteLine($"Km 5 to M is: {convertValues.kmToM(5)}");
            Console.ReadLine();*/

            FindValues findValues = new FindValues();
            double radius = 7.0f;

            findValues.firdArea(radius);
            findValues.findCircumference(radius);

            Console.ReadLine();
            

        }
    }
}
