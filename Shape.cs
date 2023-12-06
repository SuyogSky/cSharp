using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Shape
    {
        public virtual float CalculateArea()
        {
            return 0;
        }
    }

    internal class Circle : Shape
    {
        private float radius;

        public Circle(float radius)
        {
            this.radius = radius;
        }

        public override float CalculateArea()
        {
            return 3.14f * radius * radius;
        }
    }
}