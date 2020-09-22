using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace cellilar_automat_odnomer_rule15
{
    class life_rule
    {
        public static void life_rulee(int[] a, int[] b, int sum)
        {
            do
            {
                sum = 0;
                int t = 0;
                // подсчет какие клетки живут какие умирают

                for (int i = 2; i < a.GetLength(0) - 2; i++)
                {

                    t = a[i - 2] + a[i - 1] + a[i] + a[i + 1] + a[i + 2];
                    
                        if (t == 0 || t==2 || t==3 || t==4 || t==5)
                        {
                            b[i] = 0;
                        }
                        else
                        if (t==1)
                         {
                           b[i] = 1;
                         }
                    
                        

                }



                //Console.Clear();
                for (int i = 2; i < b.Length - 2; i++)
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
