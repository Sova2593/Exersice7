using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длины сторон первого треугольника:");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            int z1 = Convert.ToInt32(Console.ReadLine());
            double p1 = (x1 + y1 + z1) / 2;
            Console.WriteLine("Введите длины сторон второго треугольника:");
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());
            int z2 = Convert.ToInt32(Console.ReadLine());
            double p2 = (x2 + y2 + z2) / 2;
            double s1, s2;
            CalcSquare(x1, y1, z1, p1, x2, y2, z2, p2, out s1, out s2);
            Console.WriteLine();
            Console.WriteLine("Площадь первого треугольника равна {0:f2}",s1);
            Console.WriteLine("Площадь второго треугольника равна {0:f2}",s2);
            Console.WriteLine();
            if (s1>s2)
            {
                Console.WriteLine("Площадь первого треугольника больше второго");
            }
            else if (s1 < s2)
            {
                Console.WriteLine("Площадь второго треугольника больше первого");
            }
            else
            {
                Console.WriteLine("Площади треугольников равны");
            }
            Console.ReadKey();
        }
        static void CalcSquare(int x1, int y1, int z1, double p1, int x2, int y2, int z2, double p2,out double s1, out double s2)
        {
            s1 = Math.Sqrt(p1 * (p1 - x1) * (p1 - y1) * (p1 - z1));
            s2 = Math.Sqrt(p2 * (p2 - x2) * (p2 - y2) * (p2 - z2));
        }
    }
}
