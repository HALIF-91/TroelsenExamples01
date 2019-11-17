using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiDimensionalArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создание прямоугольного многомерного массива
            int row = 6, column = 5;
            int[,] matrix = new int[row, column];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    matrix[i, j] = i * j;
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            // matrix.Length
            // Возвращает общее кол-во элементов, а не кол-во строк
            Console.WriteLine("Кол-во элементов в многомерном массиве: {0}\n", matrix.Length);

            // Создание зубчатого многомерного массива
            int[][] jagArray = new int[row][];
            for (int i = 0; i < jagArray.Length; i++)
            {
                jagArray[i] = new int[i + column]; // строки имеют разную длину

                for (int j = 0; j < jagArray[i].Length; j++)
                {
                    Console.Write(jagArray[i][j] + " ");
                }
                Console.WriteLine();
            }
            // jagArray.Length
            // Возвращает кол-во строк, а не общее кол-во элементов
            Console.WriteLine(jagArray.Length);
            Console.ReadLine();
        }
    }
}
