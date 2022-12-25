using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая_работа_4._8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество столбцов: \t");
            int column = int.Parse(Console.ReadLine());

            Console.Write("Введите количество строк: \t");
            int line = int.Parse(Console.ReadLine());

            int[,] matrix = new int[column, line];
            Console.WriteLine();



            Random rand = new Random();
            for (int i = 0; i < column; i++)
            {
                for (int j = 0; j < line; j++)
                {
                    Console.Write("mas[" + i + "," + j + "]: ");
                    matrix[i, j] = rand.Next(99);
                    Console.WriteLine(string.Join("," matrix));
                }
                Console.WriteLine();
            }

            //  Console.WriteLine(string.Join("," matrix));



        }
    }
}

//matrix[i, j] = int.Parse(Console.ReadLine());
//matrix[column, line] = rand.Next(99);
//Console.WriteLine(matrix[column, line]);
//double[,] N = { { 0, 1 }, { 1, 1 } };
//double[,] L = { { 2, 5 }, { 7, 4 } };
//double[,] res = Matrix.Plus(N, L);
//for (int row = 0; row < res.GetLength(0); row++)
//{
//    for (int col = 0; col < res.GetLength(1); col++)
//    {
//        Console.Write(res[row, col] + "\t");
//    }
//    Console.WriteLine();
//}
//class Matrix
//{
//    public static double[,] Plus(double[,] N, double[,] L)
//    {
//        double[,] res = new double[N.GetLength(0), N.GetLength(1)];
//        for (int row = 0; row < N.GetLength(0); row++)
//        {
//            for (int col = 0; col < N.GetLength(1); col++)
//            {
//                res[row, col] = N[row, col] + L[row, col];
//            }
//        }
//        return res;
//    }

//}
