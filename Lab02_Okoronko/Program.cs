using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_Okoronko
{
    class Program
    {
        static double f(double x)
        {
            return 0.25 * Math.Pow(x, 3) + x - 1.2502;
        }
        static void Main(string[] args)
        {
            double a, b, точность;
            Console.Title = " Нахождение корня уравнения ";
            Console.Write("Введите начало отрезка: ");
            a = Double.Parse(Console.ReadLine());
            Console.Write("Введите конец отрезка: ");
            b = Double.Parse(Console.ReadLine());
            Console.Write("Введите точность: ");
            точность = Double.Parse(Console.ReadLine());
            double c = (a + b) / 2;
            while (Math.Abs(f(c)) > точность)
            {
                if ((f(a) * f(c)) <= 0)
                {
                    b = c;
                }
                else
                {
                    a = c;
                }
                c = (a + b) / 2;


            }
            string txt = "Корень уравнения на заданном отрезке равен: ";
            Console.Write(txt+c );
            Console.ReadLine();
        }
    }

}


