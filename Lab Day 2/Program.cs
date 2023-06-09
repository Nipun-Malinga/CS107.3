using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Day_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            String name;

            Console.WriteLine("Enter Name");
            name = Console.ReadLine();

            Console.WriteLine("Hello, "+ name);
            Console.ReadLine();
            

            int height, width;

            Console.WriteLine("Enter height: ");
            height =  int.Parse(Console.ReadLine());
            Console.WriteLine("Enter width: ");
            width = int.Parse(Console.ReadLine());

            int area = height*width;
            int pe = 2*(height+width); 

            Console.WriteLine("Area of the rectangle: " + area+ "\nperimeter of the rectangle: "+ pe);
            Console.ReadLine();

            
            float rad;
           
            Console.Write("Enter the radius: ");
            rad = float.Parse(Console.ReadLine());

            double area = Math.PI * (rad * rad);
            double pe = 2 * Math.PI * rad;


            Console.WriteLine("Area of the Circle: "+ area);
            Console.WriteLine("Perimeter of the circle: "+ pe);

            Console.ReadLine();

          
            int marks;

            Console.WriteLine("Enter Marks:");
            marks = int.Parse(Console.ReadLine());

            if(marks >= 70) 
            {
                Console.WriteLine("Pass");
            }
            else 
            { 
                Console.WriteLine("Fail"); 
            }
            Console.ReadLine();
            

            int month_num;

            Console.WriteLine("Enter Month Number");
            month_num = int.Parse(Console.ReadLine());

            if ( month_num > 12) 
            {
                Console.WriteLine(month_num+ " is not a valid month number.");
            }
            else if ( month_num < 1) 
            {
                Console.WriteLine(month_num + " is not a valid month number.");
            }
            else
            {
                switch (month_num)
                {
                    case 1:
                        Console.WriteLine("January");
                        break;
                    case 2:
                        Console.WriteLine("Febraury");
                        break;
                    case 3:
                        Console.WriteLine("March");
                        break;
                    case 4:
                        Console.WriteLine("April");
                        break;
                    case 5:
                        Console.WriteLine("May");
                        break;
                    case 6:
                        Console.WriteLine("June");
                        break;
                    case 7:
                        Console.WriteLine("July");
                        break;
                    case 8:
                        Console.WriteLine("August");
                        break;
                    case 9:
                        Console.WriteLine("Septermber");
                        break;
                    case 10:
                        Console.WriteLine("October");
                        break;
                    case 11:
                        Console.WriteLine("November");
                        break;
                    case 12:
                        Console.WriteLine("December");

                        break;
                }                
            }
            Console.ReadLine();
            

            int num, sum=0;

            for (int i = 0; i < 10; i++) 
            { 
                Console.WriteLine("Enter Number"+ i);
                num = int.Parse(Console.ReadLine());

                sum += num;
            }
            Console.WriteLine("Sum is" + sum);
            Console.ReadLine();

            int i, even;
            for (i = 0; i <= 100; i++)
            {
                even = i % 2;
                if (even == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();

            int num;
            while (true)
            {
                Console.WriteLine("Enter Number");
                num = int.Parse(Console.ReadLine());

                if (num < 0)
                {
                    break;
                }
            }

            
            int num = 0, output = 0;

            Console.WriteLine("Enter Number: ");
            num = int.Parse(Console.ReadLine());

            output = num % 5;

            if (output == 0)
            {
                Console.WriteLine(num + " can Be devisible by 5");
            }
            else
            {
                Console.WriteLine(num + " cannot Be devisible by 5");
            }
            Console.ReadLine();*/

            
            int[] arr = new int[10];
            int i = 0;
            String[] subs = { "Professional Development", "Introduction to Conputer Science", "Maths", "C Programmig"};

            foreach (string s in subs)
            {
                Console.WriteLine("\nEnter "+s+" Marks:");
                arr[i] = Convert.ToInt32(Console.ReadLine());

                if (arr[i] > 100)
                {
                    Console.WriteLine("Marks Cannot greater than 100");
                    break;
                }
                    else if (arr[i] < 0)
                    {
                        Console.WriteLine("Marks Cannot less than 0");
                        break;
                    }

                if (arr[i] >= 75)
                {
                    Console.WriteLine("The Result is: A");
                }
                    else if (arr[i] >=65)
                    {
                        Console.WriteLine("The Result is: B");
                    }
                        else if (arr[i] >= 55)
                        {
                            Console.WriteLine("The Result is: C");
                        }
                            else if (arr[i] >= 35)
                            {
                                Console.WriteLine("The Result is: S");
                            }
                                else 
                                { 
                                Console.WriteLine("The Result is: F"); 
                                }
                i++;
            }
            Console.ReadLine();
        }
    }
}
