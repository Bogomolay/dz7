﻿Console.Clear();

void InputMatrix(double[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
matrix[i, j] = new Random().Next(-100, 100)/10.0;
}
}
// Процедура для вывода нашей матрицы c помощью табуляции "\t" (для выравнивания текста в строках)

void PrintMatrix(double[,] matrix)
{
Console.WriteLine();
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
Console.Write(matrix[i, j] + " \t");
Console.WriteLine();
}
}

Console.Write("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
double[, ] matrix = new double[n, m];
InputMatrix(matrix);
PrintMatrix(matrix);