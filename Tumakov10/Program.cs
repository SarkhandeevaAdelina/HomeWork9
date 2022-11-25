using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Tumakov10.Papka;

namespace Tumakov10
{
    internal class Program
    {
        static void Main()
        {
            //up101();
            dz101();
            Console.ReadKey();
        }
        public static void up101()
        {
            Console.WriteLine("Шифровка строки посредством сдвига каждого символа на одну «алфавитную» позицию выше");
            ACipher aCipher = new ACipher();
            Console.Write("Введите строку:");
            string text = Console.ReadLine().ToLower();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Выберите: шифровка/расшифровка");
                string choise= Console.ReadLine();

                switch (choise)
                {
                    case "шифровка":

                        aCipher.encode(text);
                        flag = false;
                        break;
                    case "расшифровка":
                        aCipher.decode(text);
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Неккоректный ввод");
                        break;


                }
            }
            Console.WriteLine("Шифровка строки заменой каждой буквы, стоящей в алфавите на i-й позиции, на букву, расположенную в алфавите на i-й позиции с конца алфавита");
            BCipher bCipher = new BCipher();
            Console.Write("Введите строку:");
            text = Console.ReadLine().ToLower();
            flag = true;
            while (flag)
            {
                Console.WriteLine("Выберите: шифровка/расшифровка");
                string choise = Console.ReadLine();
                switch (choise)
                {
                    case "шифровка":

                        bCipher.encode(text);
                        flag = false;
                        break;
                    case "расшифровка":
                        bCipher.decode(text);
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Неккоректный ввод");
                        break;

                }
            }

        }
        public static void dz101()
        {
            Console.WriteLine("Введите изначальную позицию прямоугольника по горизонтали");
            int horizontal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите изначальную позицию прямоугольника по вертикали");
            int vertical = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите длину стороны прямоугольника");
            double weidth = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите ширину сторону прямоугольника");
            double height = Convert.ToDouble(Console.ReadLine());
            Color color = Color.white;
            bool isVisible = true;
            Rectangle rectangle = new Rectangle(horizontal, vertical, weidth, height, color, isVisible);
            Console.WriteLine(rectangle);

            Console.WriteLine("Введите изначальную позицию круга по горизонтали");
            horizontal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите изначальную позицию круга по вертикали");
            vertical = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите радиус круга");
            double radius = Convert.ToDouble(Console.ReadLine());
            Color color1 = Color.blue;
            isVisible = true;
            Circle circle = new Circle(horizontal, vertical, radius, color1, isVisible);
            Console.WriteLine(circle);
        }

    }
}
