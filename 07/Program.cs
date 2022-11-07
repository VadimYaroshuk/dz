// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

void WeekEndOrNot()
{

    Console.Write("Введите число от 1 до 7: ");
    int day = Convert.ToInt32(Console.ReadLine());


    if (day == 6 || day == 7)

    {
        Console.Write(" Выходной!!");
    }
    else
    {
        Console.Write(" Будний день((");
    }
}

WeekEndOrNot();