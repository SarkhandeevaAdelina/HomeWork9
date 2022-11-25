using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov10.Papka
{
    class Rectangle : Figure
    {
        public double weight;
        public double height;
        public double Weight
        {
            get
            {
                return weight;
            }
            private set { }
        }
        public double Height
        {
            get
            {
                return weight;
            }
            private set { }
        }
        public Rectangle(int horizontal, int vertical, double weight, double height, Color color, bool isVisible) : base(horizontal, vertical, color, isVisible)
        {
            this.height = height;
            this.weight = weight;
        }
        public double Square() => height * weight;
    }
}
