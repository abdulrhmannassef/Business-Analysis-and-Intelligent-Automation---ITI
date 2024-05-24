using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5
{
    internal class Student
    {
        int id;
        string name;
        string department;
        char grade;
        float gpa;
        static int ctr=0;

        //Setters
        public void SetId(int _id) { id = _id; }
        public void SetName(string _name) { name = _name; }
        public void SetGrade(char _grade) { grade = _grade; }
        public void SetGpa(float _gpa) { gpa = _gpa; }
        public void SetDepartment(string _department) {  department = _department; }

        //getters

        public int GetId() { return id; }
        public string GetName() { return name; }
        public char GetGrade() { return grade; }
        public float GetGpa() { return gpa; }
        public string GetDepartment() { return department; }
        public static int GetCounter() //return counter
        {
            return ctr;
        }



        //Define constructors
        public Student() //Empty one
        {
            ctr++;
            this.department = "General";
        }

        public Student(int _id , string _name)
        {
            this.id = _id;
            this.name = _name;
            this.department = "General";
            ctr++;
        }

        public Student(int _id, string _name , string _department)
        {
            this.id = _id;
            this.name = _name;
            this.department = _department;
            ctr++;
        }
        

    }
}
