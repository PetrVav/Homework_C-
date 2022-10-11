// Задача 66: Задайте значения M и N. 
// Напишите программу, 
// которая найдёт сумму натуральных элементов 
// в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.Write("Введите целое положительное число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое положительное число N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма натуральных чисел между числами M и N = {SumOfNumbers(M, N)}");

int SumOfNumbers(int M, int N)
{
    if (M == 0) return (N * (N + 1)) / 2;
    if (N == 0) return (M * (M + 1)) / 2; 
    if (M == N) return M; 
    if (M < N) return N + SumOfNumbers(M, N - 1); 
    return N + SumOfNumbers(M, N + 1);  // Если M>N
}
