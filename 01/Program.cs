// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

void KtoBolshe()
{

    Console.WriteLine("Введите два числа:");
    int number1 = Convert.ToInt32(Console.ReadLine());
    int number2 = Convert.ToInt32(Console.ReadLine());

    if (number1 == number2)
    {
        Console.WriteLine("Числа равны");
    }
    else
    {
        if (number1 < number2)
        {
            Console.Write(number2);
            Console.WriteLine(" больше");
            Console.Write(number1);
            Console.WriteLine(" меньше");
        }
        else
        {
            Console.Write(number1);
            Console.WriteLine(" больше");
            Console.Write(number2);
            Console.WriteLine(" меньше");
        }
    }
}

KtoBolshe();