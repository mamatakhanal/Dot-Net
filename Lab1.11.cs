//  Write a C# program to perform matrix multiplication using array input.

using System;
namespace Lab1
{
    internal class Matrix
    {
        /* public static void Main(string[]args) 
       {
           int i, j, k, r1, c1, r2, c2, sum = 0;
           int[,] a1 = new int[50, 50];
           int[,] a2 = new int[50, 50];
           int[,] r = new int[50, 50];
           Console.Write("Rows of 1st matrix : ");
           r1 = Convert.ToInt32(Console.ReadLine());

           Console.Write("Columns of 2nd matrix: ");
           c1 = Convert.ToInt32(Console.ReadLine());

           Console.Write("Rows of 2nd matrix : ");
           r2 = Convert.ToInt32(Console.ReadLine());

           Console.Write("Columns of 2nd matrix : ");
           c2 = Convert.ToInt32(Console.ReadLine());
           if (c1 != r2)
           {
               Console.Write("Multiplication of matrices is not possible.");
               Console.Write("\nColumn of the first matrix and row of the second matrix must be the same.");
           }
           else
           {
               Console.Write("Values of 1st matrix :\n");
               for (i = 0; i < r1; i++)
               {
                   for (j = 0; j < c1; j++)
                   {
                       Console.Write("a1[{0}],[{1}] : ", i, j);
                       a1[i, j] = Convert.ToInt32(Console.ReadLine());
                   }
               }
               Console.Write("Values of 2nd matrix :\n");
               for (i = 0; i < r2; i++)
               {
                   for (j = 0; j < c2; j++)
                   {
                       Console.Write("a2[{0}],[{1}] : ", i, j);
                       a2[i, j] = Convert.ToInt32(Console.ReadLine());
                   }
               }
               for (i = 0; i < r1; i++)
               {
                   for (j = 0; j < c2; j++)
                   {
                       sum = 0;
                       for (k = 0; k < c1; k++)
                           sum = sum + a1[i, k] * a2[k, j];
                       r[i, j] = sum;
                   }
               }
               Console.Write("\nThe multiplication of two matrices is : \n");
               for (i = 0; i < r1; i++)
               {
                   Console.Write("\n");
                   for (j = 0; j < c2; j++)
                   {
                       Console.Write("{0}\t", r[i, j]);
                   }
               }
           }
           Console.ReadLine();
       } */
    }
}

