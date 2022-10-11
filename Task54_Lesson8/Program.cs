// Задача 54: Задайте двумерный массив. 
// Напишите программу, 
// которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
int[,] massiv = new int[3, 4];
RandomFillArray(massiv);
PrintArray(massiv);
SortDescending(massiv);
Console.WriteLine();
PrintArray(massiv);

void RandomFillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
        array[i, j] = new Random().Next(0, 10);
        }
    }
}

void SortDescending(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int n = 0; n < array.GetLength(1) - 1; n++)
            {
            if (array[i, n] < array[i, n + 1])
            {
            int element = array[i, n + 1];
            array[i, n + 1] = array[i, n];
            array[i, n] = element;
            }
            }
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
        Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();
    }
}