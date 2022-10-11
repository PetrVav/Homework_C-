// Напишите программу, 
// которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int n = Convert.ToInt32(Console.ReadLine());   
if (n < 100 || n > 999)                                        
    Console.WriteLine("Это не трехзначное число!");       
else                                           
     Console.WriteLine(Convert.ToString(n)[1]);


    
