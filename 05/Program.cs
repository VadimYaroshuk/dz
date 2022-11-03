// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Введите трехзначное число: ");
int N = Convert.ToInt32(Console.ReadLine());
int ostatok = 0;
int result = 0;

ostatok = N % 100;
result = ostatok / 10;

Console.Write("Вторая цифра числа: ");
Console.WriteLine(result);

