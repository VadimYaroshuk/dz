// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите два числа:");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());

if (x < y)
{
    Console.Write(y);
    Console.WriteLine(" больше");
    Console.Write(x);
    Console.WriteLine(" меньше");
}
else
{
    Console.Write(x);
    Console.WriteLine(" больше");
    Console.Write(y);
    Console.WriteLine(" меньше");
}
