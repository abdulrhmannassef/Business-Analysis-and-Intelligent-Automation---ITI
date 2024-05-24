using System;
using System.ComponentModel.DataAnnotations;
namespace C_Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //FIRST TASK
            char op;
            int x, y;
            Console.WriteLine("Enter Operation (+,-,*,/)");
            op = char.Parse(Console.ReadLine());
            Console.Write("Enter First Number:: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Enter Second Number:: ");
            y = int.Parse(Console.ReadLine());



            //USING IF STATEMENT
            if (op == '+')
            {
                Console.Write($"Sum is ::{x + y}");
            }
            else if (op == '-')
            {
                Console.Write($"Difference is ::{x - y}");
            }
            else if (op == '*')
            {
                Console.Write($"Multiplication is ::{x * y}");
            }
            else if (op == '/')
            {
                if (y == 0) Console.WriteLine("Second Number is 0 Can not be Divided on");
                else
                {
                    Console.Write($"Division is ::{x / y}");
                }
            }




            //------------------------------------------------------




            //USING SWITCH CASE
            switch (op)
            {
                case '+':
                    Console.Write($"Sum is ::{x + y}");
                    break;
                case '-':
                    Console.Write($"Difference is ::{x - y}");
                    break;
                case '*':
                    Console.Write($"Multiplication is ::{x * y}");
                    break;
                case '/':
                    if (y == 0) Console.WriteLine("Second Number is 0 Can not be Divided on");
                    else
                    {
                        Console.Write($"Division is ::{x / y}");
                    }
                    break;

            }






            //------------------------------------------------------






            /*
             //SECOND TASK TO CHECK ODD OR EVEN 
            Console.WriteLine("Enter The Number to Check if it is odd or even:: ");
            int number =int.Parse(Console.ReadLine());
            if (number %2==0 )
            {
                Console.WriteLine($"Number {number} is even");
            }else
            {
                Console.WriteLine($"Number {number} is odd");
            }
*/


            //NUMBER PRIME OR NOT
            Console.WriteLine("Enter The Number to Chech if it is Prime or not:: ");
            int number = int.Parse(Console.ReadLine());
            bool isPrime = true;

            if (number <= 1)
            {
                isPrime = false;

            }
            for (int i = 2; i < number; i++)
            {
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                    

                }

            }
            if (isPrime)
            {
                Console.WriteLine($"the number {number} is prime");
            }
            else
            {
                Console.WriteLine($"the number {number} is not prime");
            }
            



            //------------------------------------------------------





            // FOURTH TASK FOR ARRAY
            /*  int[] numbers = new int[5];
              int sum = 0;
              Console.WriteLine("Enter the 5 numbers");
              for(int i =0; i < numbers.Length; i++)
              {
                  numbers[i] = int.Parse(Console.ReadLine());
                  sum += numbers[i];
              }

              Console.WriteLine($"Maximum Number is {numbers.Max()}");
              Console.WriteLine($"Minimum Number is {numbers.Min()}");
              Console.WriteLine($"Sum of Numbers is {sum}");

  */



        }
    }
}
