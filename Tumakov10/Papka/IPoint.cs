using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov10.Papka
{
    interface IPoint
    {
        void Moving(MovingLine movingType, int position);
        void IsVisible();
        void ChangeColor(Color color);
    }
}
