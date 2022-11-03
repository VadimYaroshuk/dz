// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите три числа:");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
int z = Convert.ToInt32(Console.ReadLine());


if (x > y)
{

    if (x > z)
    {
        Console.Write("Максимальное число:");
        Console.WriteLine(x);

    }
    else
    {
        Console.Write("Максимальное число:");
        Console.WriteLine(z);
    }
}
else
{

    if (y > z)
    {
        Console.Write("Максимальное число:");
        Console.WriteLine(y);

    }
    else

    {
        Console.Write("Максимальное число:");
        Console.WriteLine(z);
    }
}

