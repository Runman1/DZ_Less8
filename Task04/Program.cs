//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Massive4x4
{
	public class Program
	{
		public static void Main(string[] args)
		{
      int [,] numbers = new int [4,4];
      Console.WriteLine("Готовая матрица: ");     
      PrintMatrix(numbers);
		}

		public static void PrintMatrix(int[,] matrix)
    {
        int n = 4;
        matrix = new int[n, n];
        int value = 1;
        int startX = 0;
        int startY = 0;
        int endX = n - 1;
        int endY = n - 1;
         while (value <= n * n)
        {
            for (int i = startX; i <= endX; i++) {
                matrix[startY, i] = value++;
            }
            startY++;
            for (int i = startY; i <= endY; i++) {
                matrix[i, endX] = value++;
            }
            endX--;
            for (int i = endX; i >= startX; i--) {
               matrix[endY, i] = value++;
            }
            endY--;
            for (int i = endY; i >= startY; i--) {
                matrix[i, startX] = value++;
            }
            startX++;
        }
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"{matrix[i, j]:D2} ");
            }
            Console.WriteLine();
        }


    }
	}
}
