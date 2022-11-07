// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

void PrintChetnieChisla()
{
    Console.Write("Введите число: ");
    int Number = Convert.ToInt32(Console.ReadLine());
    int count = 1;
    Console.Write("Четный числа: ");
    while (count <= Number)
    {
        if (count % 2 == 0)
        {

            Console.Write(count);
            Console.Write(" ");
        }
        count++;
    }
}
PrintChetnieChisla();