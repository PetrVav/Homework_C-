// Задача 25: Напишите цикл, 
// который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число A: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число B: ");
int m = Convert.ToInt32(Console.ReadLine());
if (n == 0 || m <= 0)
Console.WriteLine("Попробуйте еще раз");
else                                     
{
 Console.WriteLine(Math.Pow(n, m)); 
}