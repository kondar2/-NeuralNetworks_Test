using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LR_7_5_AIT
{
    class Program
    {
        static void Main(string[] args)
        {
          int[,] Zero = new int[9,7] 
           {{1,1,1,1,1,1,1},
            {1,0,0,0,0,0,1},
            {1,0,1,1,1,0,1},
            {1,0,1,1,1,0,1},
            {1,0,1,1,1,0,1},
            {1,0,1,1,1,0,1},
            {1,0,1,1,1,0,1},
            {1,0,0,0,0,0,1},
            {1,1,1,1,1,1,1}};

          int[,] One = new int[9,7] 
           {{1,1,1,1,1,1,1},
            {1,1,1,0,1,1,1},
            {1,1,0,0,1,1,1},
            {1,1,1,0,1,1,1},
            {1,1,1,0,1,1,1},
            {1,1,1,0,1,1,1},
            {1,1,1,0,1,1,1},
            {1,0,0,0,0,0,1},
            {1,1,1,1,1,1,1}};

          int[,] Two = new int[9,7] 
           {{1,1,1,1,1,1,1},
            {1,0,0,0,0,0,1},
            {1,1,1,1,1,0,1},
            {1,1,1,1,1,0,1},
            {1,0,0,0,0,0,1},
            {1,0,1,1,1,1,1},
            {1,0,1,1,1,1,1},
            {1,0,0,0,0,0,1},
            {1,1,1,1,1,1,1}};

            

              //zadanie 9

           int[,] distortedOne = new int[9, 7]
            {{1,1,1,1,1,1,1},
             {1,1,1,0,1,1,1},
             {1,1,1,0,1,1,1},
             {1,1,1,0,0,1,1},
             {1,1,0,0,1,1,1},
             {1,1,1,0,1,1,1},
             {1,1,1,0,0,1,1},
             {1,0,0,0,0,0,1},
             {1,1,1,1,1,1,1}};
             

            /*
             //zadanie 6
             
           int[,] form1 = new int[1, 8]
           {{-1,1,-1,-1,1,-1,-1,-1}};  
           
            int[,] form2 = new int[1, 8]
           {{-1,-1,1,-1,-1,-1,1,-1}};  
             */

            /*
             //zadanie 4

            int[,] form1 = new int[1, 8]
           {{-1,-1,1,-1}};  
             int[,] saveForm1 = new int[1, 8]
           {{-1,-1,1,-1}};  
             
             */

            /*
             //zadanie 2

           int[,] form1 = new int[1, 8]
           {{1,-1,1,1}};  
           int[,] form2 = new int[1, 8]
           {{1,1,1,-1}};  
             */
            for (int i = 0; i < 9; i++)
          {
              for (int j = 0; j < 7; j++)
              {
                  Console.Write(One[i,j] + "\t");
              }
              Console.WriteLine();
          }


          Operation_matrix.VivodMatr(One);

          for (int i = 0; i < 9; i++)
          {
              for (int j = 0; j < 7; j++)
              {
                  Console.Write(One[i, j] + "\t");
              }
              Console.WriteLine();
          }
            Console.WriteLine("*--**-*INVERT*-*--**-");


            var TransMatr1 = new int[7, 9];
          TransMatr1 =  Operation_matrix.Transpose(One);
           

          for (int i = 0; i < 7; i++)
          {
              for (int j = 0; j < 9; j++)
              {
                  Console.Write(TransMatr1[i,j] + "\t");
              }
              Console.WriteLine();
          }

            Console.WriteLine("*--**-*TRANSPOSE*-*--**-");


            var MultiplyMatr1 = new int[7, 7];
          MultiplyMatr1 = Operation_matrix.Multiplication(TransMatr1, One);

          for (int i = 0; i < 7; i++)
          {
              for (int j = 0; j < 7; j++)
              {
                  Console.Write(MultiplyMatr1[i, j] + "\t");
              }
              Console.WriteLine();
          }

            Console.WriteLine("*--**-*MULT  TRANS1 and ONE*-*--**-");

            var MultiplyMatrZeroDiag1 = new int[7, 7];
          MultiplyMatrZeroDiag1 = Operation_matrix.ZeroDiag(MultiplyMatr1);

          for (int i = 0; i < 7; i++)
          {
              for (int j = 0; j < 7; j++)
              {
                  Console.Write(MultiplyMatrZeroDiag1[i, j] + "\t");
              }
              Console.WriteLine();
          }

            Console.WriteLine("*--**-*ZERO DIAG 1*-*--**-");
            //////////////////////////////////////////////////////////

            Operation_matrix.VivodMatr(Zero);

          var TransMatr0 = new int[7, 9];
          TransMatr0 = Operation_matrix.Transpose(Zero);

          var MultiplyMatr0 = new int[7, 7];
          MultiplyMatr0 = Operation_matrix.Multiplication(TransMatr0, Zero);

          var MultiplyMatrZeroDiag0 = new int[7, 7];
          MultiplyMatrZeroDiag0 = Operation_matrix.ZeroDiag(MultiplyMatr0);


          Operation_matrix.VivodMatr(Two);

          var TransMatr2 = new int[7, 9];
          TransMatr2 = Operation_matrix.Transpose(Two);

          var MultiplyMatr2 = new int[7, 7];
          MultiplyMatr2 = Operation_matrix.Multiplication(TransMatr2, Two);

          var MultiplyMatrZeroDiag2 = new int[7, 7];
          MultiplyMatrZeroDiag2 = Operation_matrix.ZeroDiag(MultiplyMatr2);

            ////////////////////////////////////
            ///
            for (int i = 0; i < MultiplyMatrZeroDiag0.GetLength(0); i++)
            {
                for (int j = 0; j < MultiplyMatrZeroDiag0.GetLength(1); j++)
                {
                    Console.Write(MultiplyMatrZeroDiag0[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("*--**-*ZERO DIAG 0*-*--**-");

            for (int i = 0; i < MultiplyMatrZeroDiag2.GetLength(0); i++)
            {
                for (int j = 0; j < MultiplyMatrZeroDiag2.GetLength(1); j++)
                {
                    Console.Write(MultiplyMatrZeroDiag2[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("*--**-*ZERO DIAG 2*-*--**-");



            var MatrixAddition01 = new int[7,7];
          MatrixAddition01 = Operation_matrix.Plus(MultiplyMatrZeroDiag0, MultiplyMatrZeroDiag1);

            for (int i = 0; i < MatrixAddition01.GetLength(0); i++)
            {
                for (int j = 0; j < MatrixAddition01.GetLength(1); j++)
                {
                    Console.Write(MatrixAddition01[i,j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("-----PLUS 0 1----");

            var MaskVektor = new int[7, 7];
          MaskVektor = Operation_matrix.Plus(MatrixAddition01, MultiplyMatrZeroDiag2);


            for (int i = 0; i < MaskVektor.GetLength(0); i++)
            {
                for (int j = 0; j < MaskVektor.GetLength(1); j++)
                {
                    Console.Write(MaskVektor[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("----MASK------");

 
            

          var MultZeroMask = new int[7, 7];
            //MultZeroMask = Operation_matrix.Multiplication(Two, MaskVektor);
            Operation_matrix.VivodMatr(distortedOne);
          MultZeroMask = Operation_matrix.Multiplication(distortedOne, MaskVektor);

            Console.WriteLine("-----MULTIPLY 0 and MASK------");

           
          Operation_matrix.PorogFun(MultZeroMask);
           // MultZeroMask = Operation_matrix.Transpose(MultZeroMask);
          for (int i = 0; i < MultZeroMask.GetLength(0); i++)
          {
              for (int j = 0; j < MultZeroMask.GetLength(1); j++)
              {

                  Console.Write(MultZeroMask[i, j] + "\t");
              }
              Console.WriteLine();
          }
            Console.WriteLine("-----RESULT 1------");


            /*Million ITERATION*/

            for (int i = 0; i < 1000000; i++)
            {
                MultZeroMask = Operation_matrix.Multiplication(MultZeroMask, MaskVektor);
               
            }

            Operation_matrix.PorogFun(MultZeroMask);

            for (int i = 0; i < MultZeroMask.GetLength(0); i++)
            {
                for (int j = 0; j < MultZeroMask.GetLength(1); j++)
                {
                    if (MultZeroMask[i,j] == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(MultZeroMask[i, j] + "\t");

                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(MultZeroMask[i, j] + "\t");
                    }
                    
                }
                Console.WriteLine();
            }

           


            Console.ReadKey();
        }

        
    }

}
