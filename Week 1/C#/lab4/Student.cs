using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class Student
    {
         int id;
        string name;
        char grade;
        float gpa;

        //Setters
        public void SetId(int _id) {  id = _id; }
        public void SetName(string _name) {  name = _name; }
        public void SetGrade(char _grade) {  grade = _grade; }
        public void SetGpa(float _gpa) { gpa = _gpa;}

        //getters

        public int GetId() { return id; }
        public string GetName() { return name; }
        public char GetGrade() {  return grade; }
        public float GetGpa() {  return gpa; }
    }
}
