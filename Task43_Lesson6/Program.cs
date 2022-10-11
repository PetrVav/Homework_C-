// Задача 43: 
//Напишите программу, 
// которая найдёт точку пересечения двух прямых, 
// заданных уравнениями 
// y = k1 * x + b1, 
// y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// k1 = 5,
// b1 = 2, 
// k2 = 9 
// b2 = 4, 
// -> (-0,5; -0,5)

Console.Write("Введите значение k1 (первая прямая): "); 
double k1 = Convert.ToInt32(Console.ReadLine());  
Console.Write("Введите значение b1 (первая прямая): "); 
double b1 = Convert.ToInt32(Console.ReadLine());  
Console.Write("Введите значение k2 (вторая прямая): "); 
double k2 = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите значение b2 (вторая прямая): ");
double b2 = Convert.ToInt32(Console.ReadLine());  
double x = (b1-b2) / (k2 - k1); 
double y = k1 * x + b1; 
Console.WriteLine($"Точка пересечения: ({x}, {y})");
