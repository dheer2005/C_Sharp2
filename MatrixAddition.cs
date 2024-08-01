using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fundamentals
{
    internal class MatrixAddition
    {
        public static void main(string[] args)
        {
            int m, n, i, j;
            Console.Write("Enter Number of Rows and Columns od Matrix A and B :");
            m = Convert.ToInt32(Console.ReadLine());
            n = Convert.ToInt32(Console.ReadLine());
            
            int[,] A = new int[10, 10];
            Console.Write("\nEnter the First Matrix :");
            for (i = 0; i <m; i++) 
            {
                for (j = 0; j < n; j++)
                {
                    A[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            int[,] B= new int[10, 10];
            Console.Write("\nEnter the Second Matrix");
            for(i=0;i<m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    B[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.Clear();
            Console.Write("\nMatrix A :");
            for(i = 0;i<m; i++)
            {
                for(j = 0; j < n; j++)
                {
                    Console.Write(A[i,j]+"\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nMatrix B: ");
            for(i = 0; i < m; i++)
            {
                for(j = 0; j < n; j++)
                {
                    Console.WriteLine(B[i,j]+"\t");
                }
                Console.WriteLine();
            }
            int[,] C= new int[10, 10];
            for (i = 0; i < m; i++)
            {
                for( j = 0; j < n; j++)
                {
                    C[i,j] = A[i, j] + B[i,j];
                }
            }
            Console.Write("\nSum Matrix :");
            for (i = 0; i < m; i++) 
            {
                for(j = 0; j < n; j++)
                {
                    Console.Write(C[i,j] + "\t");
                }
                Console.WriteLine();
            }
            Console.Read();
        }
        


    }
}
