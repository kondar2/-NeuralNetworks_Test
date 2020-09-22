using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace cellilar_automat_odnomer_rule15
{
    class Program
    {
        static void Main(string[] args)
        {


            Random rand = new Random();
            int[] a = new int[80];
            int[] b = new int[80];
            int sum = 1;
            //смерть

            //ввод начальных значений

            //a[12] = 1;

            //for (int i = 1; i <= b.Length - 1; i++)
            //{
            //    a[i] = 1;
            //}
            //a[2] = 0;

            
            for (int i = 0; i <= a.Length -1; i++)
            {
                a[i] = rand.Next(0,2);
            }
            

            Console.WriteLine();

            //rule150.rule155(a,b,sum);
            //Mod.mod2(a,b,sum);
            //rule18.rulee18(a,b,sum);
            //rule73.rulee73(a,b,sum);
            //rule136.rulee136(a, b, sum);
            //rule90.rulee90(a,b,sum);
            //rule30.rulee30(a,b,sum);
            life_rule.life_rulee(a,b,sum);

            Console.ReadKey();

        }
    }
}
