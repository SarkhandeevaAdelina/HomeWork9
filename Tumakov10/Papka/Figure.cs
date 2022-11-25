using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov10.Papka
{
    enum Color { green, white, blue }
    enum MovingLine { VerticallyMove, HorizontallyMove }
    class Figure : IPoint
    {
        private int horizontal;
        private int vertical;
        private Color color;
        private bool isVisible;

        public Figure(int horizontal, int vertical, Color color, bool isVisible)
        {
            this.horizontal = horizontal;
            this.vertical = vertical;
            this.color = color;
            this.isVisible = isVisible;
        }
        public int Horizontal
        {
            get
            {
                return horizontal;
            }
            private set { }
        }
        public int Vertical
        {
            get
            {
                return vertical;
            }
            private set { }
        }
        public Color Color
        {
            get
            {
                return color;
            }
            private set { }
        }
        public void IsVisible()
        {
            isVisible = !isVisible;
        }
        public void Moving(MovingLine movingLine, int position)
        {
            Console.WriteLine("Введите на какое число нужно передвинуть фигуру");
            position = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите куда вы хотите передвинуть фигуру? 0-по горизонтали; 1-по вертикали");
            while (!movingLine.Equals(0) && !movingLine.Equals(1))
            {
                Console.WriteLine("Пожалуйста, повторите ввод!");
            }
            if (movingLine.Equals(0))
            {
                horizontal += position;
                Console.WriteLine("Фигура сдвинулась на такую позицию по горизонтали:" + horizontal);
            }
            else if (movingLine.Equals(1))
            {
                vertical += position;
                Console.WriteLine("Фигура сдвинулась на такую позицию по вертикали:" + vertical);
            }
            else
            {
                Console.WriteLine("Не может сдвинуться на такую позицию");
            }
        }
        public void ChangeColor(Color color)
        {
            Console.WriteLine("Введите в какой цвет вы хотите окрасить фигуру? 0-зеленый; 1-белый; 2-голубой");
            while (!color.Equals(0) && !color.Equals(1) && !color.Equals(2))
            {
                Console.WriteLine("Пожалуйста, повторите ввод");
            }
            if (color.Equals(0))
            {
                Console.WriteLine("Фигура окрашена в зеленый");
            }
            else if (color.Equals(1))
            {
                Console.WriteLine("Фигура окрашена в белый");
            }
            else if (color.Equals(2))
            {
                Console.WriteLine("Фигура окрашена в голубой");
            }
        }
    }
}
