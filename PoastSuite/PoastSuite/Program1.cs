using System;
using System.Collections.Generic;
using System.Text;

namespace PoastSuite
{
    public class Program1
    {
        /*
        //PrintMatrix1,void method to print a matrix of this nature[,]
        public static void PrintMatrix1(double[,] matrix)
        {
            if (matrix == null)
                return;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(string.Format("{0}", matrix[i, j].ToString().PadLeft(5, ' ')));
                }
                Console.WriteLine();
            }
        }

        */

        // Method to multiply two Matrix A and Matric B - SAMPLE 1
        /*
       public static int[,] Multiply(int[,] matrix_H1, int[,] matrix_g1)
        {
            //The line below explains thats if  number of column in matrixH1 is not equal to number of row in matrix g1 write illegal matrix dimension to console else solve it. Getlength(1) = Column, Getlength(0) = Row.
            if (matrix_H1.GetLength(1) != matrix_g1.GetLength(0))
            {
                Console.WriteLine("Illegal matrix dimension");
                return null;
            }
            int[,] result = new int[matrix_H1.GetLength(0), matrix_g1.GetLength(1)];
            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < matrix_H1.GetLength(0); j++)
                {
                    for (int k = 0; k < matrix_H1.GetLength(1); k++)
                    {
                        result[i, j] += matrix_H1[i, k] * matrix_g1[k, j];
                    }
                }
            }
            return result;
        }
        */

        // Method to multiply two Matrix A and Matric B - SAMPLE 2
       public static double[,] MatrixMultiplication(double[,] A, double[,] B)
        {
            int n1 = A.GetLength(1);
            int n2 = B.GetLength(0);
            if (n1 != n2)
            {
                Console.WriteLine("The column count of the first array must equal the row count of the second array");
                return null;
            }

            double[,] C = new double[A.GetLength(0), B.GetLength(1)];

            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    for (int z = 0; z < n1; z++)
                    {
                        C[i, j] += A[i, z] * B[z, j];
                    }
                }
            }
            return C;
        }

        // Method to Multiply a Scalar with a Matrix
        public static double[,] ScalarMatrixMultiplication(double[,] matrix, double m)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = matrix[i, j] * m;
                }
            }

            return matrix;
        }

        // Method to Transpose a Matrix
       public static double[,] TransposeMatrix(double[,] matrix)
        {
            double[,] sT = new double[matrix.GetLength(1), matrix.GetLength(0)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sT[j, i] = matrix[i, j];
                }
            }
            return sT;
        }

        /*
        // Method to Add two Matrices
       public static double[][] Addition_Matrix(double[][] matrixA, double[][] matrixB)
        {
            double[][] c = new double[matrixA.Length][];
            for (int i = 0; i < matrixA.Length && i < matrixB.Length; i++)
            {
                c[i] = new double[matrixA[i].Length];
                for (int j = 0; j < matrixA[i].Length && j < matrixB[i].Length; j++)
                {
                    c[i][j] = matrixA[i][j] + matrixB[i][j];
                }
            }
            return c;
        }
        */

        /*
        // PrintMatrix2,void method to print a matrix of this nature [][]
       public static void PrintMatrix2(double[][] matrix)
        {
            if (matrix == null) return;
            foreach (double[] row in matrix)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
        */
    }

}

