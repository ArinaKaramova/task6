using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите два числа");
            var m = int.Parse(Console.ReadLine());
            var n = int.Parse(Console.ReadLine());

            Console.WriteLine(Metod(n, m));
            Console.ReadKey();
            Console.WriteLine("Введите числа");
            var x = double.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());
            Console.WriteLine(Coordinat(x, y));
            Console.ReadKey();

        }
        static bool Metod(int m, int n)
        {
            
            return (m == 0) || (n == 0);  
        }
        static bool Coordinat(double x, double y)
        {
            return ((x <= -2) && (y >= 1));
        }



    }
    
}

