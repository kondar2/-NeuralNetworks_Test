using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace cellular_automat_odnomer
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rand = new Random();
            int[] a = new int[14];
            int[] b = new int[14];
            int sum = 1;
            //смерть

            //ввод начальных значений

            a[0] = 1;

            /*
            for (int i = 0; i <= 13; i++)
            {
                a[i] = rand.Next(0,2);
            }
            */

            Console.WriteLine();



            do
            {
                sum = 0;
                int t = 0;
                // подсчет какие клетки живут какие умирают

                for (int i = 1; i < a.GetLength(0) - 1; i++)
                {

                    t = a[i - 1] + a[i] + a[i + 1];
                    if (a[i] == 0)
                    {
                        if ((t == 1) && a[i - 1] == 1)
                        {
                            b[i] = 1;
                            b[i - 1] = 0;
                        }
                        else b[i] = 0;
                    }
                    else
                    {
                        if ((t == 1) && (a[i - 1] == 1))
                        {
                            b[i] = 1;
                        }
                        else b[i] = 0;
                    }

                }



                Console.Clear();
                for (int i = 0; i < 13; i++)
                {

                    
                    if (a[i] == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green; // устанавливаем цвет
                        Console.Write("*");
                        Console.ResetColor(); // сбрасываем в стандартный
                        sum++;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red; // устанавливаем цвет
                        Console.Write("_");
                        Console.ResetColor(); // сбрасываем в стандартный
                    }
                    a[i] = b[i];


                }
                Console.WriteLine();
                Thread.Sleep(1000);

            } while (sum != 0);
            Console.ReadKey();




        }
    }
}
