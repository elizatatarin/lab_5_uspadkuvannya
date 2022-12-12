using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5_uspadkuvannya
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;

            Circle circle1 = new Circle(10);
            Circle circle2 = new Circle(20);

            Console.WriteLine("Площа першого кола = " + circle1.Area());
            Console.WriteLine("Площа другого кола = " + circle2.Area());
            Console.WriteLine("Периметр першого кола = " + circle1.Perimeter());
            Console.WriteLine("Периметр другог кола = " + circle2.Perimeter());

            Square square1 = new Square(10);
            Square square2 = new Square(20);

            Console.WriteLine("Площа першого квадрату = " + square1.Area());
            Console.WriteLine("Площа другого квадрату = " + square2.Area());
            Console.WriteLine("Периметр першого  квадрату = " + square1.Perimeter());
            Console.WriteLine("Периметр другог квадрату = " + square2.Perimeter());

            if (circle1.Area() > circle2.Area())
            {
                Console.WriteLine("Площа найбільшого кола = " + circle1.Area());
            }
            else
            {
                Console.WriteLine("Площа найбільшого кола = " + circle2.Area());
            }

            if (square1.Area() > square2.Area())
            {
                Console.WriteLine("Площа найбільшого квадрату = " + square1.Area());
            }
            else
            {
                Console.WriteLine("Площа найбільшого квадрату = " + square2.Area());
            }

            Console.ReadKey();
        }
    }
}
