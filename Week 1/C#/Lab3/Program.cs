using System;
namespace Lab3
{
    internal class Program
    {

        // Function that get tha max of two int numbers
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

        // Function that swaps between teo numbers 
        static void swap(int a, int b)
        {
            int temp;
            temp = b;
            b = a;
            a = temp;

            Console.WriteLine($"First num is {a}");
            Console.WriteLine($"Second num is {b}");
        }

        // Function that multplies two double numbers
        static double mul(double a, double b)
        {
            return a * b;
        }


        static void Main(string[] args)
        {


            /*// usage of getMax function
            
            Console.WriteLine("Enter First Number");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Second Number");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine($"Maximum of two numbers is:: {getMax(a, b)}");*/


            //----------------------------------------------------------------------------


            // usage of swap function

            /*Console.WriteLine("Enter First Number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            int b = int.Parse(Console.ReadLine());
            swap(a, b);*/


            //----------------------------------------------------------------------------


            /*//Usage of Mul Function

            Console.WriteLine("Enter First number");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Second number");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine($"Multiplication of Two numbers is {mul(a, b)}");*/
        


    }
    }
}
