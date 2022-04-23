using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Trapecii
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Метод трапеций");
            Console.WriteLine();
            Console.WriteLine("Введите нижнюю границу интергирования:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите верхнюю границу интегрирования:");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите количество частей для разбиения отрезка n:");
            int n = Convert.ToInt32(Console.ReadLine());
            int r = n;
            Console.WriteLine("Введите x0:");
            double x0 = Convert.ToDouble(Console.ReadLine());
            double h = (b-a)/n;
            Console.WriteLine("Шаг интегрирования:" + h);
            double f;
            double y2;
            int k = 0;// Число, которое изменяет индекс массива "d".
            double [] d = new double [(int)n+1];//массив для нахождения функции на заданном отрезке 
            double [] d2 = new double[(int)n+1];// массив для нахождения 2 производной y"
            n += 3;
            for(int i = 0; i <= n; i++)
            {
                f = (3 * Math.Pow(x0,2) + Math.Sin(x0))/Math.Pow(x0,2);
                
                if (i <= 10)
                {                   
                    d[k] = f; 
                    k++; 
                }
                else
                {
                    k = k + 0;
                }
                
                Console.WriteLine("| " + x0 + "\t|" + f + "\t|");
                x0 += h; 
            }

            Console.WriteLine();
            Console.WriteLine("Формула трапеции:");
            double t = (b - a) / (2 * r) * (d[0] + d[10] + 2 * (d[1]+d[2]+d[3]+d[4]+d[5]+d[6]+d[7]+d[8]+d[9]));
            Console.WriteLine("Ответ: " + t);
            do
            {
                switch (k)
                {
                    case 0:
                        y2 = Math.Abs((1 / Math.Pow(h, 2)) * (2 * d[0] - 5 * d[1] + 4 * d[2] - d[3]));
                        d2[k] = y2;
                        Console.WriteLine("| " + y2 + "\t|");
                        break;
                    case 1:
                        y2 = Math.Abs((1 / Math.Pow(h, 2)) * (2 * d[1] - 5 * d[2] + 4 * d[3] - d[4]));
                        d2[k] = y2;
                        Console.WriteLine("| " + y2 + "\t|");
                        break;
                    case 2:
                        y2 = Math.Abs((1 / Math.Pow(h, 2)) * (2 * d[2] - 5 * d[3] + 4 * d[4] - d[5]));
                        d2[k] = y2;
                        Console.WriteLine("| " + y2 + "\t|");
                        break;
                    case 3:
                        y2 = Math.Abs((1 / Math.Pow(h, 2)) * (2 * d[3] - 5 * d[4] + 4 * d[5] - d[6]));
                        d2[k] = y2;
                        Console.WriteLine("| " + y2 + "\t|");
                        break;

                }
                k++;

            } while (k <= 10);
            

            
                
               

            Console.ReadKey();
        }
    }
}
