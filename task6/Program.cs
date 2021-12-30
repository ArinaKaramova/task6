using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            var myNumbers = Goldba(Resheto(100));

            Console.ReadKey();
        }
        static List<int> Resheto(int n)
        {
            List<int> myList = new List<int>();
            for (int i = 2; i <= n; i++)
            {
                if ((i % 2) != 0 || i == 2) myList.Add(i);
            }
            for (int i = 0; i < myList.Count; i++)
            {
                for (int k = 2; k <= n; k++)
                {
                    myList.Remove(myList[i] * k);
                }
            }

            return myList;
        }
        static double Goldba(List<int> myList)
        {
            List<int> myList2 = new List<int>();
            myList.ForEach(delegate (int i)
            {
                for (int l = 2; l < 100; l++)
                {
                    myList2.Add(i + 2 * l * l);
                }
            });
            return '1';
        }
    }
}
