// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным 
// и минимальным элементов массива.
// [3 7 22 2 78] -> 76
int size = 5;
int[] elements = new int[size];
RandomFillArray(elements);
int max = elements[0];
int min = elements[0];
for (int i = 0; i < elements.Length; i++)
{
    if (elements[i] > max)
    {
        max = elements[i];
    }
    else if (elements[i] < min)
    {
        min = elements[i];
    }
}
Console.WriteLine($"Максимальный элемент массива: {max}");
Console.WriteLine($"Минимальный элемент массива: {min}");
Console.WriteLine($"Разница между max и min элементами = {max-min}");
void RandomFillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 20);
    }
    Console.WriteLine("[" + string.Join(", ", array) + "]");
}


