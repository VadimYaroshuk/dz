// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).


Console.Write("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());

int ostatok = 0;

ostatok = x % 2;

if (ostatok == 0)
{
    Console.Write(x);
    Console.WriteLine(" - четное число");
}
else
{

    Console.Write(x);
    Console.WriteLine(" - нечетное число");

}