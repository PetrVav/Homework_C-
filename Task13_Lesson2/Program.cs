// Напишите программу, 
// которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int n = Convert.ToInt32(Console.ReadLine());   
if (n < 99)                                       
    Console.WriteLine("Третьей цифры нет!");       
else                                               
    Console.WriteLine(Convert.ToString(n)[2]); 