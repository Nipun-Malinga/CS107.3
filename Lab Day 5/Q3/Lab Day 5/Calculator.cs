using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Day_5
{
    internal class Calculator
    {
        public int choice;
        public int num1;
        public int num2;

        public Calculator(int choice, int num1, int num2)
        {
            this.choice = choice;
            this.num1 = num1;
            this.num2 = num2;
        }
        
        public int calculation()
        {
            int output = 0;
            if (choice == 1)
            {
                output = num1 + num2;
            }
            else if (choice == 2)
            {
                output = num1 - num2;
            }
            else if (choice == 3)
            {
                output = num2 * num1;
            }
            else if (choice == 4)
            {
                output = num1 / num2;
            }         
            return output;
        }
    }
}
