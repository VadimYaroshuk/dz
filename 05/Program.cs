// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.


void VtoroeChislo()
{
    Console.Write("Введите трехзначное число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int result = 0;

    result = number % 100 / 10;
    Console.Write("Вторая цифра числа: ");
    Console.WriteLine(result);
}
VtoroeChislo();