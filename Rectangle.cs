using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Rectangle
    {
        private float length;
        private float width;

        public Rectangle(float length, float width)
        {
            this.length = length;
            this.width = width;
        }

        public float CalculateArea()
        {
            return length * width;
        }
    }
}