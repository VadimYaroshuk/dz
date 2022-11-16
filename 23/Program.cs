// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка



void Fill2Array(int[,] matrix)
{
    Random random = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = random.Next(1, 9);

        }
    }
}

void Print2Array(int[,] matrix2)
{
    for (int i = 0; i < matrix2.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            Console.Write(" " + matrix2[i, j]);
        }
        Console.WriteLine();
    }
}

void MinSumRow(int[,] matrix4)
{
    int sumrow = 0;
    int numberrow = 0;
    for (int i = 0; i < matrix4.GetLength(0); i++)

    {

        int sum = 0;

        for (int j = 0; j < matrix4.GetLength(1); j++)
        {
            sum = sum + matrix4[i, j];

        }

        if (i == 0)
        {
            sumrow = sum;
        }
        else
        {
            if (sum < sumrow)
            {
                sumrow = sum;
                numberrow = i + 1;
            }
        }


    }
    Console.WriteLine("Строка под номером: " + numberrow);
}




int[,] array = new int[5, 5];
Console.WriteLine();
Fill2Array(array);
Print2Array(array);
Console.WriteLine();
MinSumRow(array);
Console.WriteLine();
