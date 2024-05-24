using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5
{
    internal class Point
    {

        int x;
        int y;
        private static int ctr =0;

        //Setters
        public void SetX(int _x) { x = _x; }
        public void SetY(int _y) { y = _y; }
        //Getters
        public float GetX() { return x; }
        public float GetY() { return y; }




        // this CTOR intialies x,y with 0
        public Point()
        {
            this.x = 0;
            this.y = 0;
            ctr++;
        }

        //CTOR takes x ,y everytime creates an object of the class
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
            ctr++;
        }

        public static int GetCounter()
        {
            return ctr;
        }
    }
}
