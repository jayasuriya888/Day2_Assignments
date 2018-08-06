using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Shapes
    {
        double ar;
        public void shape()
        {

        }
        public void area(int side)
        {
            ar = side * side;
        }
        public void area(int len, int brd)
        {
            ar = len * brd;
        }

        public void area(int brd, int ht, double half)
        {
            ar = half * brd * ht;
        }
        public void area(double pi, int r)
        {
            ar = pi * r * r;
        }
        public void showData()
        {
            Console.WriteLine("Area :" + ar);
        }
    }
}
