//  Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


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

static int[,] MultMatrix(int[,] mat1, int[,] mat2)
{ 
    int[,] arrayrezalt = new int[mat1.GetLength(0), mat2.GetLength(1)];

    if (mat1.GetLength(1) == mat2.GetLength(0))
    {
       
        for (int i = 0; i < arrayrezalt.GetLength(0); i++)
        {
            for (int j = 0; j < arrayrezalt.GetLength(1); j++)
            {
                arrayrezalt[i, j] = 0;
                for (int n = 0; n < mat1.GetLength(1); n++)
                {
                    arrayrezalt[i, j] = arrayrezalt[i, j] + mat1[i, n] * mat2[n, j];
                }
            }
        }
    }
    else
    {
        Console.WriteLine("Умножение матриц невозможно");

    }
return arrayrezalt;
}

int[,] array1 = new int[2, 2];
int[,] array2 = new int[2, 2];

Console.WriteLine();
Fill2Array(array1);
Fill2Array(array2);
Print2Array(array1);
Console.WriteLine();
Print2Array(array2);
Console.WriteLine();
Print2Array(MultMatrix(array1,array2));
Console.WriteLine();
