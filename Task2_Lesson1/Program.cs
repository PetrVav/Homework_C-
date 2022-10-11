// Задача 2
// НАПИСАТЬ ПРОГРАММУ КОТОРАЯ НА ВХОД ПРИНИМАЕТ 2 ЧИСЛА
// и выдает , какое число большее, а какое меьшее
Console.WriteLine("Задача 2");
Console.Write("а=");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("b=");
int b = Convert.ToInt32(Console.ReadLine());
if(a > b) 
{
    Console.WriteLine("max=" + a);
} 
else if (b > a) 
{
    Console.WriteLine("max=" + b);
} 
else if (a == b) 
{
    Console.WriteLine("a=b, " + a);
}
