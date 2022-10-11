// Задача 4
// Напишите программу, 
// которая принимает на вход три числа 
// и выдает максимальное из этих чисел
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if(b > max)
{
    max = b;
} 
if (c > max) 
{
    max = c;
}
Console.WriteLine(max);
