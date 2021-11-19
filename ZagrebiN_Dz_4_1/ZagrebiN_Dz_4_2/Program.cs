using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_MathM
{
    class Program
    {
        static void Main()
        {
            int sum = 0;
            int n = 10;
            int m = 10;
            int[,] mas = new int[n, m];
            Random rand = new Random();


            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                {
                    mas[i, j] = rand.Next(-2, 10);
                }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(mas[i, j] + "      ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < m; j++)
                {
                    if (mas[i, j] < 0)
                    {
                        mas[i, j] = mas[i, j] * (-1);
                    }
                    sum += mas[i, j];
                }
            }
            Console.WriteLine("Сумма = " + sum);

            int res = 0;
            int[] d = { -1, 0, 1 };
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    bool flag = false;
                    foreach (int dx in d)
                        foreach (int dy in d)
                            if (dx + i >= 0 && dx + i < n &&
                            dy + j >= 0 && dy + j < m &&
                            mas[i, j] >= mas[i + dx, j + dy])
                                if (dx != 0 && dy != 0)
                                {
                                    flag = true;
                                    break;
                                }
                    if (!flag) res++;
                }

            }
            Console.WriteLine("Минимумов : " + res);



        }
    }
}
