using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5_1_2_Heming
{
    class Operation_matrix
    {
        public static double[,] Multi_zero_five(double[,] One)
        {
            //take 7 str
            // трансформировать в 1 и -1
            double[,] MatrNumber = new double[One.GetLength(0), One.GetLength(1)];


            for (int i = 0; i < MatrNumber.GetLength(0); i++)
            {
                for (int j = 0; j < MatrNumber.GetLength(1); j++)
                {
                    MatrNumber[i, j] = One[i, j] * 0.5;
                }
            }
            
            return MatrNumber;
        }


        public static double[,] VivodMatr(double[,] One)
        {
            //take 7 str
            // трансформировать в 1 и -1
            double[,] MatrNumber = new double[One.GetLength(0), One.GetLength(1)];
           
            for (int i = 0; i < MatrNumber.GetLength(0); i++)
            {
                for (int j = 0; j < MatrNumber.GetLength(1); j++)
                {
                    if (One[i, j] == 1)
                    {
                        MatrNumber[i, j] = -1;
                    }

                    if (One[i, j] == 0)
                    {
                        MatrNumber[i, j] = 1;
                    }
                }
            }
            return MatrNumber;
        }



        public static double[,] Array2ToArray1(double[,] One)
        {
            double[,] result = new double[1,35];
            int z = 0;
            for (int i = 0; i < One.GetLength(0); i++)
                for (int j = 0; j < One.GetLength(1); j++)
                {
                    result[0,z] = One[i, j];
                    z++;
                }

            return result;
        }

        public static double[,] ThreeArrayToOneArray(double[,] Singal1, double[,] Singal2, double[,] Singal3, double[,] Singal4)
        {
            double[,] result = new double[35, 4];
            for (int i = 0; i < Singal1.GetLength(1); i++)
			{
			   result[i,0] = Singal1[0,i];
			}

            for (int j = 0; j < Singal2.GetLength(1); j++)
			{
			   result[j,1] = Singal2[0,j];
			}

            for (int k = 0; k < Singal3.GetLength(1); k++)
			{
			   result[k,2] = Singal3[0,k];
			}

            for (int h = 0; h < Singal4.GetLength(1); h++)
            {
                result[h, 3] = Singal4[0, h];
            }

            return result;
        }










        public static double[,] Transpose(double[,] matrix)
        {

            var newMatrix = new double[matrix.GetLength(1), matrix.GetLength(0)];

            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    newMatrix[i, j] = matrix[j, i];
                }
            }

            return newMatrix;
        }


        public static double[,] Multiplication(double[,] a, double[,] b)
        {
            if (a.GetLength(1) != b.GetLength(0)) throw new Exception("Матрицы нельзя перемножить");
            double[,] r = new double[a.GetLength(0), b.GetLength(1)];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    for (int k = 0; k < b.GetLength(0); k++)
                    {
                        r[i, j] += a[i, k] * b[k, j];
                    }
                }
            }
            return r;
        }

        public static int[,] ZeroDiag(int[,] matr)
        {
            for (int i = 0; i < 7; i++)
            {
                matr[i, i] = 0;
            }
            return matr;
        }


        public static int[,] Plus(int[,] N, int[,] L)
        {
            int[,] res = new int[N.GetLength(0), N.GetLength(0)];
            for (int row = 0; row < N.GetLength(0); row++)
            {
                for (int col = 0; col < N.GetLength(1); col++)
                {
                    res[row, col] = N[row, col] + L[row, col];
                }
            }
            return res;
        }

        public static void PorogFun(double[,] matr)
        {
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    if (matr[i, j] >= 1)
                    {
                        matr[i, j] = 7.6;
                    }
                    else
                    {
                        if (matr[i, j] >= 0 || matr[i, j] <= 1)
                        {
                            matr[i, j] = 7.6 * matr[i, j] / 35;
                        }
                        else
                        {
                            matr[i, j] = 0;
                        }
                    }
                }
            }
            
        }


    }
}
