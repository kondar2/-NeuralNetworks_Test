using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace cellilar_automat_odnomer_rule15
{
    class rule136
    {

        public static void rulee136(int[] a, int[] b, int sum)
        {
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
                        b[i] = 0;
                    }
                    else
                    {
                        if ((t == 2 && (a[i+1]==1 && a[i-1]==0)) || t==3)
                        {
                            b[i] = 1;

                        }
                        else b[i] = 0;
                    }

                }



                //Console.Clear();
                for (int i = 1; i < b.Length - 1; i++)
                {


                    if (a[i] == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("1");
                        Console.ResetColor();
                        sum++;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("0");
                        Console.ResetColor();
                    }

                    a[i] = b[i];


                }
                Console.WriteLine();
                Thread.Sleep(100);

            } while (sum != 0);
        }
    }
}
