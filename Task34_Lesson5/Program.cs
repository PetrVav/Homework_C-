// Задача 34: 
//Задайте массив заполненный случайными 
// положительными трёхзначными числами. 
// Напишите программу, которая покажет 
// количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Write("Введите кол-во элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] elements = new int[size];

RandomFillArray(elements);
int count = 0;
for (int i = 0; i < elements.Length; i++)
{
    if (elements[i] % 2 == 0)
    count++;
}

Console.WriteLine($"Кол-во четных чисел в массиве: {count} ");

void RandomFillArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100,1000);
    }
    Console.WriteLine("[" + string.Join(", ", array) + "]");
}


   



