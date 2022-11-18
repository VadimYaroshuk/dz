﻿// // Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// // M = 1; N = 15 -> 120
// // M = 4; N = 8. -> 30

int SumDigits(int m, int n)
{
    if (m == n)
    {
        return m;
    }
    else
    {
        return m + SumDigits(m + 1, n);
    }
}
Console.WriteLine($"Сумма = {SumDigits(4, 8)}"); 