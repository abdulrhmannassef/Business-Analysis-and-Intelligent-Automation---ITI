using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class Emp
    {
        int id;
        int age;
        string name;
        double salary;
        string position;

        public void SetId(int _id) {  id = _id;   }
        public void SetAge(int _age) {  age = _age; }
        public void SetName(string _name) {  name = _name; }
        public void SetSalary(double _salary) { salary = _salary; }
        public void SetPosition(string _position) { position = _position; }


        public string GetName() { return name; }
        public double GetSalary() {  return salary; }
        public string GetPosition() { return position; }
        public int GetAge() { return age; }
        public int GetId() { return id; }


    }
}
