using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual
{
    class Program
    {
        static void Main(string[] args)
        {
            Linear l = new Linear(-3, 6);
            l.Solve();
            Square sq = new Square(4, -20, 25);
            sq.Solve();
            Console.WriteLine("--------------------------------");
            Shape[] s = {
                new SSquare(1, 2, 3),
                new Circle(1, 2, 3),
                new SSquare(4, 5, 6),
                new Rectangle(7, 8, 9, 10),
                new Ellipse(2, 2, 2, 2) ,
                new Rectangle(8,6,4,2)
            };
            int[] c = { 0, 0, 0, 0 };
            foreach (var item in s)
            {
                item.Show();
                item.CalculateArea();
                item.CalculatePerimetr();
                Console.WriteLine("--------------------------------");
                if (item is SSquare)
                    c[0]++;
                else if (item is Rectangle)
                    c[1]++;
                else if (item is Circle)
                    c[2]++;
                else if (item is Ellipse)
                    c[3]++;
            }
            Console.WriteLine($"Square - {c[0]}");
            Console.WriteLine($"Rectangle - {c[1]}");
            Console.WriteLine($"Circle - {c[2]}");
            Console.WriteLine($"Ellipse - {c[3]}");
        }
    }
}
