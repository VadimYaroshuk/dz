﻿// Задача 25: Напишите метод, который принимает на вход два числа (A и B) и возводит число A в целую степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.Write("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("В какую степень возведем: ");
int z = Convert.ToInt32(Console.ReadLine());

int result = 1;


for (int i = 0; i < z; i++)
{
    result = result * x;

}
Console.Write(result);