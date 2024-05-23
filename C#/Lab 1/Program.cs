using System;
namespace Lab_1
{
    internal class Program
    {

        // Function to get the max out of two numbers
        static int getMax(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }


        // Function that add two numbers
        static int add(int a, int b)
        {
            return a + b;
        }

        //Function that multply 2 double numbers
        static double mul(double a, double b)
        {
            return a * b;
        }


        static void Main(string[] args)
        {



            /*// First program
            Console.WriteLine("Enter First Number");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Second Number");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine($"Maximum of two numbers is:: {getMax(a, b)}");*/

            //-------------------------------------------------------------------------------------------

            /*//Second program
            Console.WriteLine("Enter First num");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Second num");
            int y = int.Parse(Console.ReadLine());

            
            int sum = add(x, y);
            Console.WriteLine($"The sum of Two numbers is {sum}");*/



            //-------------------------------------------------------------------------------------------



            /*//Third program
            Console.WriteLine("Enter First number");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Second number");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine($"Multiplication of Two numbers is {mul(a, b)}");*/

        }
    }
}
