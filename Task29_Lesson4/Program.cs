// Задача 29: Напишите программу, 
// которая задаёт массив из 8 элементов 
// и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int[] array = new int[8];  
Console.WriteLine("Начальный массив: [" + string.Join(", ", array) + "]");
                            
    for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(0, 9); 

Console.WriteLine("Конечный массив: [" + string.Join(", ", array) + "]"); 