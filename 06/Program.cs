// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


Console.Write("Введите трехзначное число: ");
var N = Convert.ToInt32(Console.ReadLine());
var ostatok = 0;

ostatok = N / 100;

if (ostatok >= 1)

{
    if (ostatok <= 10)
    {
        Console.Write(N / 100);

    }
    else
    {
        Console.Write(ostatok % 10);
    }
}
else
{
    Console.Write("3ей цифры числа нет");

}


