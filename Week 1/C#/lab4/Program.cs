using System;
namespace lab4
{
    internal class Program
    {


        //SWAP Function by reference()
        static void swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"a is {a} b is {b}");
        }




        static void Main(string[] args)
        {
            // Creating an object of Emp Class
            Emp e1 = new Emp();
            e1.SetId(1);
            e1.SetPosition("Manager");
            e1.SetAge(25);
            e1.SetName("Abdulrhman");
            e1.SetSalary(12000);
            Console.WriteLine($"{e1.GetName()} is a {e1.GetPosition()} with a Salary {e1.GetSalary()} and his Age is {e1.GetAge()}");

            Console.WriteLine("--------------------------------------\n--------------------------------------");

            // Creating an object of Student Class
            Student s1 = new Student();
            s1.SetId(1);
            s1.SetName("Abdulrhman");
            s1.SetGpa(3.12f);
            s1.SetGrade('A');
            Console.WriteLine($"{s1.GetName()} his id is {s1.GetId()} his Grade is {s1.GetGrade()} with a GPA {s1.GetGpa}");

            Console.WriteLine("--------------------------------------\n--------------------------------------");


            //Creating an objec tof Class Point
            Point point = new Point();
            point.SetX(0);
            point.SetY(0);

            Console.WriteLine($"Cordinates of Point is X:: {point.GetX()} Y:: {point.GetY()}");

            Console.WriteLine("--------------------------------------\n--------------------------------------");


            //Creating an object of BankAccount
            BankAccount bankAccount = new BankAccount();
            bankAccount.SetAccountNo(100022522);
            bankAccount.SetName("abdulrhman");

            Console.WriteLine($"your Account No is {bankAccount.GetAccountNo()} and your Balance is {bankAccount.GetBalance()}");
            bankAccount.withdraw(566210001);
            bankAccount.deposit(1000);
            Console.WriteLine($"Currect balance is {bankAccount.GetBalance()}");

            Console.WriteLine("--------------------------------------\n--------------------------------------");


            //Using Swap Function
            int a = 10;
            int b = 20;
            swap(ref a,ref b);










        }
    }
}
