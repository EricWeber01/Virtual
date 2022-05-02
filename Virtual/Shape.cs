using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Virtual
{
    abstract class Shape
    {
        public abstract void Show();
        public abstract void CalculateArea();
        public abstract void CalculatePerimetr();
    }
    class SSquare : Shape
    {
        public int x;
        public int y;
        public int side;
        public SSquare(int _x, int _y, int _side)
        {
            x = _x;
            y = _y;
            side = _side;
        }
        public override void Show()
        {
            Console.WriteLine($"Square\nx - {x} | y - {y} | Side - {side}");
        }
        public override void CalculateArea()
        {
            Console.WriteLine($"Area - {side * side}");
        }
        public override void CalculatePerimetr()
        {
            Console.WriteLine($"Perimetr - {side * 4}");
        }
    }
    class Rectangle : Shape
    {
        public int x;
        public int y;
        public int a;
        public int b;
        public Rectangle(int _x, int _y, int _a, int _b)
        {
            x = _x;
            y = _y;
            a = _a;
            b = _b;
        }
        public override void Show()
        {
            Console.WriteLine($"Rectangle\n x - {x} | y - {y} | A - {a} | B - {b}");
        }
        public override void CalculateArea()
        {
            Console.WriteLine($"Area - {a * b}");
        }
        public override void CalculatePerimetr()
        {
            Console.WriteLine($"Perimetr - {2 * a + 2 * b}");
        }
    }
    class Circle : Shape
    {
        public int x;
        public int y;
        public int r;
        public Circle(int _x, int _y, int _r)
        {
            x = _x;
            y = _y;
            r = _r;
        }
        public override void Show()
        {
            Console.WriteLine($"Circle\n x - {x} | y - {y} | R - {r} ");
        }
        public override void CalculateArea()
        {
            Console.WriteLine($"Area - {3.14 * (r * r)}");
        }
        public override void CalculatePerimetr()
        {
            Console.WriteLine($"Perimetr - {2 * 3.14 * r}");
        }
    }
    class Ellipse : Shape
    {
        public int x;
        public int y;
        public int a;
        public int b;

        public Ellipse(int _x, int _y, int _a, int _b)
        {
            x = _x;
            y = _y;
            a = _a;
            b = _b;
        }
        public override void Show()
        {
            Console.WriteLine($"Ellipse\n xSq - {x} | ySq - {y} | aSq - {a} | bSq - {b} ");
        }
        public override void CalculateArea()
        {
            Console.WriteLine($"Area - {3.14 * (a / 2) * (b / 2)}");
        }
        public override void CalculatePerimetr()
        {
            Console.WriteLine($"Perimetr - {(4 * (3.14 * (a / 2) * (b / 2))) / ((a / 2) + (b / 2))}");
        }
    }
}
