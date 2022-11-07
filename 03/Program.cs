// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).


void ChetNechet()
{
    Console.Write("Введите число: ");
    int x = Convert.ToInt32(Console.ReadLine());
    if (x % 2 == 0)
    {
        Console.Write(x + " - четное число");
    }
    else
    {
        Console.Write(x + " - нечетное число");
    }
}
ChetNechet();