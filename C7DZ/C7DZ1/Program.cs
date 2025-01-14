﻿// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Write("Задайте m (↨): ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте n (→): ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Clear();
Console.WriteLine($"m (↨) = {m}, n (→) = {n}.");
Console.WriteLine();

double[,] array = new double[m, n];

GetArrayDouble(array);

WriteArray(array);

Console.WriteLine();

void GetArrayDouble(double[,] array)
{
  for (int i = 0; i < m; i++)
  {
    for (int j = 0; j < n; j++)
    {
      array[i, j] = new Random().NextDouble() * 20 - 10;
    }
  }
}

void WriteArray (double[,] array){
for (int i = 0; i < m; i++)
  {
      for (int j = 0; j < n; j++)
      {
        double alignNumber = Math.Round(array[i, j], 1);
        Console.Write("|" + alignNumber + "| ");
      }
      Console.WriteLine();
  }
}
Console.WriteLine(" $  Ý  ♂  ♀");