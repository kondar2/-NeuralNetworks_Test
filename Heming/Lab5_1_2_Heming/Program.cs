using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5_1_2_Heming
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] One = new double[7, 5] 
           {{1,1,1,0,1},
            {1,1,0,0,1},
            {1,0,1,0,1},
            {0,1,1,0,1},
            {1,1,1,0,1},
            {1,1,1,0,1},
            {1,1,1,0,1}};

            double[,] Two = new double[7, 5] 
           {{1,0,0,1,1},
            {0,1,1,0,1},
            {1,1,1,0,1},
            {1,1,0,1,1},
            {1,0,1,1,1},
            {0,1,1,1,1},
            {0,0,0,0,1}};

            double[,] Three = new double[7, 5] 
           {{1,0,0,1,1},
            {0,1,1,0,1},
            {1,1,1,0,1},
            {1,0,0,1,1},
            {1,1,1,0,1},
            {0,1,1,0,1},
            {1,0,0,1,1}};

            double[,] Four = new double[7, 5]
           {{0,1,1,1,1},
            {0,1,1,1,1},
            {0,1,1,0,1},
            {0,1,1,0,1},
            {0,0,0,0,1},
            {1,1,1,0,1},
            {1,1,1,0,1}};

            double[,] EOne = new double[7, 5]
           {{1,1,0,0,1},
            {1,1,1,0,1},
            {0,1,1,1,1},
            {1,1,0,1,1},
            {1,1,1,1,1},
            {1,1,1,1,1},
            {1,1,0,0,0}};

            double[,] ETwo = new double[7, 5]
           {{1,1,1,0,1},
            {1,1,0,1,1},
            {1,1,1,0,1},
            {0,1,1,1,1},
            {1,1,1,0,1},
            {1,1,1,1,1},
            {1,1,1,1,1}};

            double[,] EThree = new double[7, 5]
           {{1,1,0,1,1},
            {1,0,1,1,1},
            {1,0,1,0,1},
            {0,1,1,0,1},
            {1,0,0,1,1},
            {1,1,0,1,1},
            {1,1,0,1,1}};

            double[,] EFour = new double[7, 5]
           {{1,1,1,1,1},
            {0,1,0,1,1},
            {1,1,1,0,1},
            {1,0,1,1,0},
            {1,1,1,1,1},
            {1,1,1,0,1},
            {1,0,0,1,1}};


            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(One[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine();

           var Vektor_One = new double[7,5]; 
           Vektor_One = Operation_matrix.VivodMatr(One);
           for (int i = 0; i < 7; i++)
           {
               for (int j = 0; j < 5; j++)
               {
                   Console.Write(Vektor_One[i, j] + "\t");
               }
               Console.WriteLine();
           }

           Console.WriteLine();

           var MultZerFiveONE = Operation_matrix.Multi_zero_five(Vektor_One);
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(MultZerFiveONE[i, j]);
                }
                Console.WriteLine();
            }


            var Vektor_Two = new double[7, 5];
            Vektor_Two = Operation_matrix.VivodMatr(Two);
            var Vektor_Three = new double[7, 5];
            Vektor_Three = Operation_matrix.VivodMatr(Three);
            var Vektor_Four = new double[7, 5];
            Vektor_Four = Operation_matrix.VivodMatr(Four);

            var MultZerFiveTWO = Operation_matrix.Multi_zero_five(Vektor_Two);
            var MultZerFiveTHREE = Operation_matrix.Multi_zero_five(Vektor_Three);
            var MultZerFiveFOUR = Operation_matrix.Multi_zero_five(Vektor_Four);


            var Signal1 = new double[1, 35];
            Signal1 = Operation_matrix.Array2ToArray1(MultZerFiveONE);
            var Signal2 = new double[1, 35];
            Signal2 = Operation_matrix.Array2ToArray1(MultZerFiveTWO);
            var Signal3 = new double[1, 35];
            Signal3 = Operation_matrix.Array2ToArray1(MultZerFiveTHREE);
            var Signal4 = new double[1, 35];
            Signal4 = Operation_matrix.Array2ToArray1(MultZerFiveFOUR);

            /*ИСКАЖЕННЫЕ СИГНАЛЫ*/

            var EVektor_One = new double[7, 5];
            EVektor_One = Operation_matrix.VivodMatr(EOne);
            var EVektor_Two = new double[7, 5];
            EVektor_Two = Operation_matrix.VivodMatr(ETwo);
            var EVektor_Three = new double[7, 5];
            EVektor_Three = Operation_matrix.VivodMatr(EThree);
            var EVektor_Four = new double[7, 5];
            EVektor_Four = Operation_matrix.VivodMatr(EFour);

            var EMultZerFiveONE = Operation_matrix.Multi_zero_five(EVektor_One);
            var EMultZerFiveTWO = Operation_matrix.Multi_zero_five(EVektor_Two);
            var EMultZerFiveTHREE = Operation_matrix.Multi_zero_five(EVektor_Three);
            var EMultZerFiveFOUR = Operation_matrix.Multi_zero_five(EVektor_Four);


            var ESignal1 = new double[1, 35];
            ESignal1 = Operation_matrix.Array2ToArray1(EMultZerFiveONE);
            var ESignal2 = new double[1, 35];
            ESignal2 = Operation_matrix.Array2ToArray1(EMultZerFiveTWO);
            var ESignal3 = new double[1, 35];
            ESignal3 = Operation_matrix.Array2ToArray1(EMultZerFiveTHREE);
            var ESignal4 = new double[1, 35];
            ESignal4 = Operation_matrix.Array2ToArray1(EMultZerFiveFOUR);



            var W = new double[4,35];
            W = Operation_matrix.ThreeArrayToOneArray(Signal1, Signal2, Signal3, Signal4);




            Console.WriteLine("--------------------------");

            for (int i = 0; i < W.GetLength(0); i++)
            {
                for (int j = 0; j < W.GetLength(1); j++)
                {
                    Console.Write(W[i, j]);
                }
                Console.WriteLine();
            }


            var Y11 = new double[1, 4];
            var Y12 = new double[1, 4];
            var Y13 = new double[1, 4];
            var Y14 = new double[1, 4];

            var EY11 = new double[1, 4];
            var EY12 = new double[1, 4];
            var EY13 = new double[1, 4];
            var EY14 = new double[1, 4];

            EY11 = Operation_matrix.Multiplication(ESignal1, W);
            EY12 = Operation_matrix.Multiplication(ESignal2, W);
            EY13 = Operation_matrix.Multiplication(ESignal3, W);
            EY14 = Operation_matrix.Multiplication(ESignal4, W);

            //var Signal0T = Operation_matrix.Transpose(Signal0);
            Y11 = Operation_matrix.Multiplication(Signal1, W);
            
                for (int j = 0; j < W.GetLength(1); j++)
                {
                    Console.Write(Y11[0, j] + "\t");
                }
            Console.WriteLine();

            Y12 = Operation_matrix.Multiplication(Signal2, W);

            for (int j = 0; j < W.GetLength(1); j++)
            {
                Console.Write(Y12[0, j] + "\t");
            }
            Console.WriteLine();

            Y13 = Operation_matrix.Multiplication(Signal3, W);

            for (int j = 0; j < W.GetLength(1); j++)
            {
                Console.Write(Y13[0, j] + "\t");
            }
            Console.WriteLine();

            Y14 = Operation_matrix.Multiplication(Signal4, W);

            for (int j = 0; j < W.GetLength(1); j++)
            {
                Console.Write(Y14[0, j] + "\t");
            }
            Console.WriteLine();


            double E = 0.33;

           //var ArraySumm0 = new double[1, 3];

            double Sum11 = Y11[0, 0] - E * (Y11[0, 1] + Y11[0, 2] + Y11[0, 3]);
            double Sum12 = Y11[0, 1] - E * (Y11[0, 0] + Y11[0, 2] + Y11[0, 3]);
            double Sum13 = Y11[0, 2] - E * (Y11[0, 0] + Y11[0, 1] + Y11[0, 3]);
            double Sum14 = Y11[0, 3] - E * (Y11[0, 0] + Y11[0, 1] + Y11[0, 2]);


            Console.WriteLine("\n Signal 1 \n");
            Console.WriteLine(Sum11);
            Console.WriteLine(Sum12);
            Console.WriteLine(Sum13);
            Console.WriteLine(Sum14);


            double Sum21 = Y12[0, 0] - E * (Y12[0, 1] + Y12[0, 2] + Y12[0, 3]);
            double Sum22 = Y12[0, 1] - E * (Y12[0, 0] + Y12[0, 2] + Y12[0, 3]);
            double Sum23 = Y12[0, 2] - E * (Y12[0, 0] + Y12[0, 1] + Y12[0, 3]);
            double Sum24 = Y12[0, 3] - E * (Y12[0, 0] + Y12[0, 1] + Y12[0, 2]);


            Console.WriteLine("\n Signal 2 \n");
            Console.WriteLine(Sum21);
            Console.WriteLine(Sum22);
            Console.WriteLine(Sum23);
            Console.WriteLine(Sum24);

            double Sum31 = Y13[0, 0] - E * (Y13[0, 1] + Y13[0, 2] + Y13[0, 3]);
            double Sum32 = Y13[0, 1] - E * (Y13[0, 0] + Y13[0, 2] + Y13[0, 3]);
            double Sum33 = Y13[0, 2] - E * (Y13[0, 0] + Y13[0, 1] + Y13[0, 3]);
            double Sum34 = Y13[0, 3] - E * (Y13[0, 0] + Y13[0, 1] + Y13[0, 2]);


            Console.WriteLine("\n Signal 3 \n");
            Console.WriteLine(Sum31);
            Console.WriteLine(Sum32);
            Console.WriteLine(Sum33);
            Console.WriteLine(Sum34);

            double Sum41 = Y14[0, 0] - E * (Y14[0, 1] + Y14[0, 2] + Y14[0, 3]);
            double Sum42 = Y14[0, 1] - E * (Y14[0, 0] + Y14[0, 2] + Y14[0, 3]);
            double Sum43 = Y14[0, 2] - E * (Y14[0, 0] + Y14[0, 1] + Y14[0, 3]);
            double Sum44 = Y14[0, 3] - E * (Y14[0, 0] + Y14[0, 1] + Y14[0, 2]);


            Console.WriteLine("\n Signal 4 \n");
            Console.WriteLine(Sum41);
            Console.WriteLine(Sum42);
            Console.WriteLine(Sum43);
            Console.WriteLine(Sum44);


            /*----------------------ИСКАЖЕННЫЕ СИГНАЛЫ-----------------------*/

            double ESum11 = EY11[0, 0] - E * (EY11[0, 1] + EY11[0, 2] + EY11[0, 3]);
            double ESum12 = EY11[0, 1] - E * (EY11[0, 0] + EY11[0, 2] + EY11[0, 3]);
            double ESum13 = EY11[0, 2] - E * (EY11[0, 0] + EY11[0, 1] + EY11[0, 3]);
            double ESum14 = EY11[0, 3] - E * (EY11[0, 0] + EY11[0, 1] + EY11[0, 2]);


            Console.WriteLine("\n ESignal 1 \n");
            Console.WriteLine(ESum11);
            Console.WriteLine(ESum12);
            Console.WriteLine(ESum13);
            Console.WriteLine(ESum14);


            double ESum21 = EY12[0, 0] - E * (EY12[0, 1] + EY12[0, 2] + EY12[0, 3]);
            double ESum22 = EY12[0, 1] - E * (EY12[0, 0] + EY12[0, 2] + EY12[0, 3]);
            double ESum23 = EY12[0, 2] - E * (EY12[0, 0] + EY12[0, 1] + EY12[0, 3]);
            double ESum24 = EY12[0, 3] - E * (EY12[0, 0] + EY12[0, 1] + EY12[0, 2]);


            Console.WriteLine("\n ESignal 2 \n");
            Console.WriteLine(ESum21);
            Console.WriteLine(ESum22);
            Console.WriteLine(ESum23);
            Console.WriteLine(ESum24);

            double ESum31 = EY13[0, 0] - E * (EY13[0, 1] + EY13[0, 2] + EY13[0, 3]);
            double ESum32 = EY13[0, 1] - E * (EY13[0, 0] + EY13[0, 2] + EY13[0, 3]);
            double ESum33 = EY13[0, 2] - E * (EY13[0, 0] + EY13[0, 1] + EY13[0, 3]);
            double ESum34 = EY13[0, 3] - E * (EY13[0, 0] + EY13[0, 1] + EY13[0, 2]);


            Console.WriteLine("\n ESignal 3 \n");
            Console.WriteLine(ESum31);
            Console.WriteLine(ESum32);
            Console.WriteLine(ESum33);
            Console.WriteLine(ESum34);

            double ESum41 = EY14[0, 0] - E * (EY14[0, 1] + EY14[0, 2] + EY14[0, 3]);
            double ESum42 = EY14[0, 1] - E * (EY14[0, 0] + EY14[0, 2] + EY14[0, 3]);
            double ESum43 = EY14[0, 2] - E * (EY14[0, 0] + EY14[0, 1] + EY14[0, 3]);
            double ESum44 = EY14[0, 3] - E * (EY14[0, 0] + EY14[0, 1] + EY14[0, 2]);


            Console.WriteLine("\n ESignal 4 \n");
            Console.WriteLine(ESum41);
            Console.WriteLine(ESum42);
            Console.WriteLine(ESum43);
            Console.WriteLine(ESum44);

            /*------------Пропуск через пороговую функцию---------------*/


            var ArraySumm1 = new double[1, 4];
            ArraySumm1[0, 0] = Sum11;
            ArraySumm1[0, 1] = Sum12;
            ArraySumm1[0, 2] = Sum13;
            ArraySumm1[0, 3] = Sum14;

            Operation_matrix.PorogFun(ArraySumm1);

            Console.WriteLine("\nПропуск через пороговую функцию");
            for (int i = 0; i < ArraySumm1.GetLength(1); i++)
            {
                Console.WriteLine(ArraySumm1[0, i]);
            }
            
            var ArraySumm2 = new double[1, 4];
            var ArraySumm3 = new double[1, 4];
            var ArraySumm4 = new double[1, 4];


            //n = 35

            /*когда получил y я вычисляю внутреннюю сумму получаем число*/
            /*пропускаю через функцию активации и получаю ответ число*/




            Console.ReadKey();
        }
    }
}



