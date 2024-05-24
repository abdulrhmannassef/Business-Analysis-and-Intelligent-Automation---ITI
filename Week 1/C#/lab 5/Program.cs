using System;
namespace lab_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // creating an object of BankAccount class
            BankAccount ba1 = new BankAccount();
            BankAccount ba2 = new BankAccount(2995324312 , "abdulrhman");
            BankAccount ba3 = new BankAccount(3214556, 2000);

            Console.WriteLine($"user 3 {ba3.GetBalance()}");
            Console.WriteLine($"Total users {BankAccount.GetCounter()}");



            Console.WriteLine();
            Console.WriteLine();




            // creating an object of Employee class
            Employee e1 = new Employee();
            Employee e2 = new Employee(1 , "IT");
            Employee e3 = new Employee(2 , "HR" , "Head");
            Console.WriteLine($"Total Employees {Employee.GetCounter()}");





            Console.WriteLine();
            Console.WriteLine();



            // Creating an object of Student Class
            Student s1 = new Student();
            Student s2 = new Student(123 , "abdulrhman");
            Student s3 = new Student(123, "abdo", "CS");

            Console.WriteLine($"total number of student is {Student.GetCounter()}");







            Console.WriteLine();
            Console.WriteLine();




            //Creating an objec tof Class Point
            Point p1 = new Point();
            Point p2 = new Point(0,0);
            Point p3 = new Point(+2,5);
            Console.WriteLine($"total number of points is {Point.GetCounter()}");



            


           
        }
    }
}
