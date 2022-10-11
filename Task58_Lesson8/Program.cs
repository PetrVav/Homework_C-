// Задача 58: Задайте две матрицы. 
// Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
int rows = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов: ");
int[,] array = new int[rows, columns];
int[,] SecondArray = new int[rows, columns];
int[,] ResultArray = new int[rows, columns];

FillArrayRandom(array);
PrintArray2D(array);

Console.WriteLine();

FillArrayRandom(SecondArray);
PrintArray2D(SecondArray);

Console.WriteLine();

if (array.GetLength(0) != SecondArray.GetLength(1))
{
    Console.WriteLine("Невозможно перемножить");
    return;
}
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < SecondArray.GetLength(1); j++)
    {
        ResultArray[i, j] = 0;
        for (int k = 0; k < array.GetLength(1); k++)
        {
            ResultArray[i, j] += array[i, k] * SecondArray[k, j];
        }
    }
}

PrintArray2D(ResultArray);
int ReadInt(string ArraySize)
{
    Console.Write(ArraySize);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray2D(int[,] array)
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
