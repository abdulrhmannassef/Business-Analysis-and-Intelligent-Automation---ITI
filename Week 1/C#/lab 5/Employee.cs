using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5
{
    internal class Employee
    {
        // define attributes
        int id;
        int age;
        string name;
        double salary;
        string position;
        string department;
        static int ctr = 0; // to define how many employees in the company.

        // setters
        public void SetId(int _id) { id = _id; }
        public void SetAge(int _age) { age = _age; }
        public void SetName(string _name) { name = _name; }
        public void SetSalary(double _salary) { salary = _salary; }
        public void SetPosition(string _position) { position = _position; }
        public void SetDepartment(string _department) { department = _department; }

        //getters
        public string GetName() { return name; }
        public double GetSalary() { return salary; }
        public string GetPosition() { return position; }
        public int GetAge() { return age; }
        public int GetId() { return id; }
        public string GetDepartment() { return department; }

        // define constructors

        //Empty constructor
        public Employee() {
            ctr++;
        }

   

        // constructor with id , department
        public Employee(int _id, string _department)
        {
            this.id = _id;
            this.department = _department;
            ctr++;
        }
        // counstuctor with id,name,positoin
        public Employee(int _id , string _name, string _position)
        {
            this.id = _id;
            this.name = _name;
            this.position = _position;
            ctr++;
        }

        public static int GetCounter()
        {
            return ctr;
        }


    }
}
