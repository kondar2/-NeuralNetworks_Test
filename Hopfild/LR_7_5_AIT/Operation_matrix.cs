using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LR_7_5_AIT
{
    class Operation_matrix
    {

        public static void VivodMatr(int[,] One)
        {
            //take 7 str
            // трансформировать в 1 и -1
            //int[,] MatrNumber = new int[,] { };

            for (int j = 0; j < One.GetLength(1); j++)
            {
                for (int i = 0; i < One.GetLength(0); i++)
                {
                    if (One[i, j] == 1)
                    {
                        One[i, j] = -1;
                    }

                    if (One[i, j] == 0)
                    {
                        One[i, j] = 1;
                    }
                }
            }
            //return MatrNumber;
        }

        public static int[,] Transpose(int[,] matrix)
        {

           var newMatrix = new int[matrix.GetLength(1),matrix.GetLength(0)];

           for (int i = 0; i < newMatrix.GetLength(0); i++)
           {
              for (int j = 0; j < newMatrix.GetLength(1); j++)
               {
                 newMatrix[i, j] = matrix[j, i];
               }
           }

           return newMatrix;
         }




        public static int[,] Multiplication(int[,] a, int[,] b)
        {
            if (a.GetLength(1) != b.GetLength(0)) throw new Exception("Матрицы нельзя перемножить");
            int[,] r = new int[a.GetLength(0), b.GetLength(1)];
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
            for (int i = 0; i < matr.GetLength(0); i++)
            {
              matr[i, i] = 0;    
            }
            return matr;
        }


        public static int[,] Plus(int[,] N, int[,] L)
        {
            int[,] res = new int[N.GetLength(0), N.GetLength(1)];
            for (int row = 0; row < N.GetLength(0); row++)
            {
                for (int col = 0; col < N.GetLength(1); col++)
                {
                    res[row, col] = N[row, col] + L[row, col];
                }
            }
            return res;
        }

        public static void/*int[,]*/ PorogFun(int[,] matr)
        {
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    if (matr[i,j] >= 0)
	                {
                        matr[i, j] = 1;
	                } else
	                  {
                        matr[i,j] = -1;
	                  }
                }
            }
            //return matr;
        }
    }
}
