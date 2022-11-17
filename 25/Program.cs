// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


void Fill3Array(int[,,] matrix)
{
    Random random = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int n = 0; n < matrix.GetLength(2); n++)
            {
                matrix[i, j, n] = random.Next(10, 99);

                if (n != 0)
                {
                    while (matrix[i, j, n] == matrix[i, j, n - 1])
                    {
                        matrix[i, j, n] = random.Next(1, 99);
                    }
                }

            }
        }
    }
}

void Print3Array(int[,,] matrix2)
{
    for (int i = 0; i < matrix2.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int n = 0; n < matrix2.GetLength(2); n++)
            {
                Console.Write(" " + matrix2[i, j, n] + " (" + i + "," + j + "," + n + ") ");
            }
            Console.WriteLine();
        }
    }
}

Console.WriteLine();
int[,,] array3 = new int[3, 3, 3];
Fill3Array(array3);
Print3Array(array3);
Console.WriteLine();