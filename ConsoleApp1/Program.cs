﻿using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[,] matrix = new int[3,3];
            for (int i = 0; i < matrix.GetLength(0); i++ )
                for (int j = 0; j < matrix.GetLength(1); j++)
                matrix[i, j] = i * 3 + j;
            Console.WriteLine(matrix);
        }
    }
}