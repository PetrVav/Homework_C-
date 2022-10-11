// Задача 50. 
// Напишите программу, 
// которая на вход принимает 
// позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента 
// или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Ввод:
// 1
// 2
// Вывод:
// 4

Console.WriteLine("Введите размеры массива");
int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[n, m];
 
for (int i = 0; i < array.GetLength(0); i++) 
{
    for (int j = 0; j < array.GetLength(1); j++)
        array [i, j] = Convert.ToInt32(new Random().Next(0,21));  
}
 
for (int i = 0; i < array.GetLength(0); i++) 
{
    for (int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i,j] + "\t  ");
        Console.WriteLine();
}
 
 Console.WriteLine("Введите индекс элемента");
 int rows = Convert.ToInt32(Console.ReadLine());
 int colums = Convert.ToInt32(Console.ReadLine());
 if (rows > m || colums > n)
 Console.WriteLine("Такого числа в массиве нет");
 else
 {
 object a = array.GetValue(rows, colums);
 Console.WriteLine(a);
 }