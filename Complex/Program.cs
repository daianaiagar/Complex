using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ioordonatele primului numar complex:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            complex1(a, b);
            Console.WriteLine();
            Console.WriteLine("Coordonatele celui de-al doilea numar complex:");
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            complex2(c, d);
            sumadif(a, b, c, d);
            Console.WriteLine(" ");
            FormGeo(a, b, 1);
            Console.WriteLine(" ");
            Console.WriteLine("Introduceti puterea n ");
            int n = int.Parse(Console.ReadLine());
            FormGeo(a, b, n);
        }

        private static void suma(object v1, object v2)
        {
            throw new NotImplementedException();
        }

        static void complex1(int a, int b)
        {
            Console.WriteLine("x= " + a + " + i*" + b);
        }
        static void complex2(int c, int d)
        {
            Console.WriteLine("y= " + c + " + i*" + d);
        }
        static void sumadif(int a, int b, int c, int d)
        {
            Console.WriteLine("x+y = " + (a + c) + " + i*" + (b + d));
            Console.WriteLine(" ");
            Console.WriteLine("x-y = " + (a - c) + " - i*" + (b - d));
            Console.WriteLine(" ");
            Console.WriteLine("x*y = " + (a * c - b * d) + " + i*" + (a * d + b * c));
            Console.WriteLine(" ");
        }
        static void FormGeo(int a, int b, int n)
        {
            // forma trigonometrica: x = r(cos Teta + i sin Teta), unde r = sqrt(a ^ 2 + b ^ 2)(modulul) si Teta = arctg(b / a)(argumentul)

            //x ^ n = r ^ n(cos n * Teta + i sin n * Teta)(ridicarea la putere in forma trigonometrica)
            double r = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            double teta = Math.Atan(b / a);
            Console.WriteLine("Forma geometrica :  x = " + r + "(cos" + teta + "+ i*sin" + teta);
            Console.WriteLine(" ");
            double s = Math.Sin(teta);
            double c = Math.Cos(teta);
            Console.WriteLine($"Dupa rezolvare, forma geometrica a lui x este x = {r * c} + i*{r * s}");
            Console.WriteLine(" ");
            double s2 = Math.Sin(n * teta);
            double c2 = Math.Cos(n * teta);
            Console.WriteLine($"x^{n}= {r * c2} + i*{r * s2}");
        }
    }
    
}
