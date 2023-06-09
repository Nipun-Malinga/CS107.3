using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Day_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Enter a Number");
            int inp = int.Parse(Console.ReadLine());

            if (inp % 2 == 0) 
            {
                Console.WriteLine($"Number {inp} is a Even Number");
            }
            else
            {
                Console.WriteLine($"Number {inp} is a Odd Number");
            }
            Console.ReadLine();
            

            Console.Write("Enter a word: ");
            string words = Console.ReadLine();
            words = words.ToUpper();

            int a = 0, e = 0, i = 0, o = 0, u = 0;

            foreach (Char word in words)
            {
                if (word == 'A')
                {
                    a++;
                }
                else if (word == 'E')
                {
                    e++;
                }
                else if (word == 'I')
                {
                    i++;
                }
                else if (word == 'O')
                {
                    o++;
                }
                else if (word == 'U')
                {
                    u++;
                }

            }

            Console.WriteLine($"A's {a} E's{e} I's{i} O's{o} U's{u}");
            Console.ReadLine();
            

            int[] arr = { 1, 2, 3, 40, 5, 6, 7, 8, 9, 10, 11, };

            int max = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }  
            }
            Console.WriteLine($"The Largest Number is {max}");
            Console.ReadLine();
            

            int number;

            Console.Write("Enter Number:");
            number = int.Parse(Console.ReadLine());

            String numberString = number.ToString();
            int sum = 0;
            for (int i = 0; i < numberString.Length; i++)
            {
                int digit = int.Parse(numberString[i].ToString());
                sum += digit;
            }

            Console.WriteLine($"Sum is {sum}");
            */

            /* int[] arr = { 2, 1, 4, 7, 5, 8, 4, 7, 9, 3, 5 };
            int temp = 0;
            int length = arr.Length - 1;

            for (int x = 0; x < arr.Length / 2; x++)
            {
                temp = arr[x];
                arr[x] = arr[length];
                arr[length] = temp;
                length--;
            }
            Console.WriteLine("Reversed Array: ");
            for (int x = 0; x < arr.Length; x++)
            {
                Console.Write($"{arr[x]} ");
            }
            Console.ReadLine(); */

            int input = 0;

            
            
            Console.Write("Enter a number: ");
            input = Convert.ToInt32(Console.ReadLine());
            String conString = input.ToString();
            
            
            
        }
    }
}
