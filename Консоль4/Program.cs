using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Консоль4
{
    class Program
    {
        static void Main(string[] args)
        {
            //////////////////////////////////////////Задание №1///////////////////////////
            Console.Write("Введите x: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Введите n: ");
            int n = int.Parse(Console.ReadLine());
            if (x != 0)
            {
                Console.WriteLine(Fanc(x, n));
            }
            //////////////////////////////////////////Задание №2///////////////////////////
            Console.Write("Введите n: ");
            n = int.Parse(Console.ReadLine());
            Fanc2(n);
            Console.ReadKey();
        }

        static double Fanc(double x, int n)
        {
            if (n == 0) return 1;
            if (n < 0) return 1 / Math.Pow(x, Math.Abs(n));
            if (n > 0) return x * Math.Pow(x, n - 1);
            Fanc(1, 0);
            return 0;
        }
        static void Fanc2(int n, int s = 0)
        {
            if (n > 0)
            {
                for (int i = 0; i < s; i++)
                    Console.Write(" ");
                for (int i = 1; i < n + 1; i++)
                    Console.Write(i);
                if (s == 0) Console.Write("\t n");
                if (s > 0) Console.Write("\t n-" + s);
                Console.WriteLine();
                Fanc2(n - 1, s + 1);
            }
        }
    }
}
