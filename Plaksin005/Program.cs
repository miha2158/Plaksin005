using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plaksin005
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[13];
            int n = 0;

            Console.WriteLine("Введите кол-во эл-тов масива");
            while ((!int.TryParse(Console.ReadLine(), out n)) || (n <= 0))
                Console.WriteLine("Кол-во должно быть целым числом больше 0");

            int i = 0;
            for (; i < n; i++)
            {
                arr[i] = (n - i) / 2 + 1;
                Console.Write("{0}, ",arr[i]);
            }
            Console.WriteLine();

            i = 1;
            do
            {
                arr[0]--;
                arr[i]--;
            }
            while (n > 4 && n < 13 && i++ < 7);

            arr[0] = (int)Math.Sqrt(arr[0]);

            Console.Write(arr[0]);

            Console.ReadKey(true);
        }
    }
}
