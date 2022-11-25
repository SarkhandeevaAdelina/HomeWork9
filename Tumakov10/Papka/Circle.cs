using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov10.Papka
{
    class Circle : Figure
    {
        public double radius;
        public double Radius
        {
            get
            {
                return radius;
            }
            private set { }
        }
        public Circle(int horizontal, int vertical, double radius, Color color, bool isVisible) : base(horizontal, vertical, color, isVisible)
        {
            this.radius = radius;
        }
        public double Square(double square) => square = Math.PI * radius * radius;
    }
}
