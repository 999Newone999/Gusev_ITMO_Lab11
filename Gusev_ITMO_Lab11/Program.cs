using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gusev_ITMO_Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double buffer=0;
            bool notException;

            Console.WriteLine("Вычисление корня уравнения kx+b=0 ");
            Console.WriteLine("k и b - вещественные числа.");

            RootFinding rootFinding = new RootFinding();

            do
            {
                notException = true;
                Console.Write("Введите значение k = ");
                try
                {
                    buffer = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    notException = false;
                }
                rootFinding.K = buffer;
            } while (notException == false);

            do
            {
                notException = true;
                Console.Write("Введите значение b = ");
                try
                {
                    buffer = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    notException = false;
                }
            } while (notException == false);
            rootFinding.B = buffer;
            if (rootFinding.B > 0)
            {
                Console.WriteLine("Корень уравнения: \"{0}*X + {1} = 0\" равен: {2}", rootFinding.K, rootFinding.B, rootFinding.Root());
            }
            else if (rootFinding.B < 0)
            {
                Console.WriteLine("Корень уравнения: \"{0}*X - {1} = 0\" равен: {2}", rootFinding.K, -rootFinding.B, rootFinding.Root());
            }
            else
            {
                Console.WriteLine("Корень уравнения: \"{0}*X = 0\" равен: {1}", rootFinding.K, rootFinding.Root());
            }
            Console.ReadKey();
        }
    }

    struct RootFinding
    {
        public double B { set; get; }
        public double K { set; get; }

        internal double Root()
        {
            return (-this.B/this.K);
        }
    }
}
