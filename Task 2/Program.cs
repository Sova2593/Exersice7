using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину ребра куба:");
            int a = Convert.ToInt32(Console.ReadLine());
            double s, v;
            CalcSV(a, out s, out v);
            Console.WriteLine();
            Console.WriteLine("Площадь поверхности куба равна {0:f2}", s);
            Console.WriteLine("Объем куба равен {0:f2}", v);
            Console.ReadKey();
        }
        static void CalcSV(int a, out double s, out double v)
        {
            s = 6 * Math.Pow(a, 2);
            v = Math.Pow(a, 3);
        }
    }
}
