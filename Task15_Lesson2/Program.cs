// Задача 15: Напишите программу, 
// которая принимает на вход цифру, 
// обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
Console.Write("Введите день недели : ");
int n = Convert.ToInt32(Console.ReadLine());

while (n < 1 || n > 7)
{
      Console.WriteLine("Такого дня недели нет! Попробуй еще раз: ");
      n = Convert.ToInt32(Console.ReadLine());
}
if (n == 1)
Console.WriteLine("Нет");
if (n == 2)
Console.WriteLine("Нет");
if (n == 3)
Console.WriteLine("Нет");
if (n == 4)
Console.WriteLine("Нет");
if (n == 5)
Console.WriteLine("Нет");
if (n == 6)
Console.WriteLine("Да, этот день выходной");
if (n == 7)
Console.WriteLine("Да, этот день выходной");