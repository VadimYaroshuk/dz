// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

void Sort2Array(int[,] matrix3)

{
    int temperdigit = 0;

    for (int i = 0; i < matrix3.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3.GetLength(1); j++)
        {
            for (int x = 1; x < matrix3.GetLength(1); x++)
            {

                if (matrix3[i, x - 1] < matrix3[i, x])
                {
                    temperdigit = matrix3[i, x - 1];
                    matrix3[i, x - 1] = matrix3[i, x];
                    matrix3[i, x] = temperdigit;
                }

            }

        }

    }

}

int[,] array = new int[5,5];
Fill2Array(array);
Print2Array(array);
Sort2Array(array);
Console.WriteLine();
Print2Array(array);



