using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Zagrebin_DZ4_1

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество элементов массива: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            int[] b = new int[n];
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                a[i] = r.Next(-25, 25);
                Console.Write(a[i].ToString() + "  ");
            }
            Console.WriteLine();
            int min = Math.Abs(a[0]);
            for (int i = 0; i < n; i++)
                if (Math.Abs(a[i]) <= Math.Abs(min))
                    min = a[i];
            Console.WriteLine("Минимальный по модулю элемент: " + min.ToString());


            //макисмум
            var MaxABS = a.Max(m => Math.Abs(m));
            Console.WriteLine("Максимальный элемент: " + MaxABS);

            //сумма модулей
            var Sum = a.SkipWhile(m => m != 0).Sum(m => Math.Abs(m));
            Console.WriteLine("Сумма модулей: " + Sum);


            //преобразование массива
            b = a.Where((item, num) => num % 2 != 0).Concat(a.Where((item, num) => num % 2 == 0)).ToArray<int>();
            Console.WriteLine("Преобразованный массив: ");
            for (int i = 0; i < n; i++)
                Console.Write(b[i].ToString() + "  ");
            Console.ReadKey();
        }
    }
}
