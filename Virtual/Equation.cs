using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual
{
    abstract class Equation
    {
        protected double a;
        protected double b;
        protected double c;
        public Equation(double _a, double _b)
        {
            a = _a;
            b = _b;
            c = 0;
        }
        public Equation(double _a, double _b, double _c)
        {
            a = _a;
            b = _b;
            c = _c;
        }
        public abstract void Solve();
    }
    class Linear : Equation
    {
        public Linear(double _a, double _b) : base(_a, _b)
        {

        }
        public override void Solve()
        {
            if (a == 0)
            {
                if (b == 0)
                {
                    Console.WriteLine("Х - любое число\n");
                }
                else
                {
                    Console.WriteLine("Нет решений");
                }
            }
            else
            {
                Console.WriteLine($"X = {-1 * (b / a)}");
            }
        }

    }
    class Square : Equation
    {
        public Square(double _a, double _b, double _c) : base(_a, _b, _c)
        {

        }
        public override void Solve()
        {
            double x1, x2;
            double discriminant = Math.Pow(b, 2) - 4 * a * c;
            if (discriminant < 0)
            {
                Console.WriteLine("Квадратное уравнение не имеет корней");
            }
            else
            {
                if (discriminant == 0)
                {
                    x1 = -b / (2 * a);
                    x2 = x1;
                }
                else
                {
                    x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                    x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                }

                Console.WriteLine($"x1 = {x1}; x2 = {x2}");
            }
        }
    }
}