// Задача 36: Задайте одномерный массив, 
// заполненный случайными числами. 
// Найдите сумму элементов, 
// стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
int size = 4;
int[] elements = new int[size];
RandomFillArray(elements);

int SummaIndex = 0;
for (int i = 1; i < elements.Length; i += 2)
{
    SummaIndex += elements[i];
}
Console.WriteLine($"Сумма нечетных индексов = {SummaIndex} ");

void RandomFillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-50, 50);
    }
    Console.WriteLine("[" + string.Join(", ", array) + "]");
}



