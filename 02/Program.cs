// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

void MaxIz3()
{
    Console.WriteLine("Введите три числа:");
    int number1 = Convert.ToInt32(Console.ReadLine());
    int number2 = Convert.ToInt32(Console.ReadLine());
    int number3 = Convert.ToInt32(Console.ReadLine());

    if (number1 > number2)
    {
        if (number1 > number3)
        {
            Console.Write("Максимальное число: " + number1);

        }
        else
        {
            Console.Write("Максимальное число: " + number3);
        }
    }
    else
    {
        if (number2 > number3)
        {
            Console.Write("Максимальное число: " + number2);

        }
        else
        {
            Console.Write("Максимальное число: " + number3);
        }
    }
}

MaxIz3();