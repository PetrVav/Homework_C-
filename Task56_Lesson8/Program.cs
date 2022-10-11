// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 
// 1 строка

int[,] massiv = new int[4, 4];
RandomFillArray(massiv);
PrintArray(massiv);
Console.WriteLine();
NumberRowMinSummaElements(massiv);

void NumberRowMinSummaElements(int[,] array)
{
    int RowMin = 0;
    int RowMinSumma = 0;
    int RowSumma = 0;
    for (int i = 0; i < massiv.GetLength(1); i++)
    {
        RowMin += massiv[0, i];
    }
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++) RowSumma += massiv[i, j];
        if (RowSumma < RowMin)
        {
            RowMin = RowSumma;
            RowMinSumma = i;
        }
        RowSumma = 0;
    }
    Console.Write($"{RowMinSumma + 1} cтрока");
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void RandomFillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}
