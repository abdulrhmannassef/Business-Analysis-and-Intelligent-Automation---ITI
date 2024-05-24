using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class Point
    {
        //we need for point in space an X an Y
        float x;
        float y;
        //Setters
        public void SetX(float _x) {  x = _x; }
        public void SetY(float _y) {  y = _y; }
        //Getters
        public float GetX() { return x; }
        public float GetY() { return y; }

    }
}
