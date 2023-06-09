// See https://aka.ms/new-console-template for more information
namespace Lab_Day_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            string name;
            float batch;

            Console.WriteLine("Enter your name: ");
                name = Console.ReadLine();
            Console.WriteLine("Enter your batch: ");
                batch = float.Parse(Console.ReadLine());

            Console.WriteLine("Hi "+ name +" Your batch is " +  batch);
            Console.ReadKey();

            */
            

            double radius;
            double area;

            Console.WriteLine("Enter radius");
                radius = Convert.ToInt32(Console.ReadLine());

            area = radius * radius * Math.PI;

            Console.WriteLine($"Area is: {area}");
            Console.ReadKey();

            /*
            int x;
            int y;

            Console.WriteLine("Enter First Number");
                x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
                y = int.Parse(Console.ReadLine());

            int z = x + y;

            Console.WriteLine("Sum is: " + z);
            Console.ReadLine();

            

            float sal;
            float t_rate;

            Console.WriteLine("Enter Salary: ");
                sal = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter tax Rate: ");
                t_rate = float.Parse(Console.ReadLine());

            float tax = (sal * t_rate) / 100;
            float new_s = sal-tax;

            Console.WriteLine("Tax is: " + tax);
            Console.WriteLine("New Salary is: " + new_s);
            Console.ReadKey();*/
               
        }
    }
}
