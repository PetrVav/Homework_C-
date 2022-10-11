// Задача 27: Напишите программу, 
// которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine()); 
int count =0; 
if (n < 10)                               
Console.WriteLine("Вы ввели одну цифру!");
if (n < 0) 
Console.WriteLine("Ошибка, попробуйте еще раз!");
else                                   
    while (n >= 1)

    {
    count += n % 10;
    n = (n -n%10)/ 10;   
    }
Console.Write(count);



