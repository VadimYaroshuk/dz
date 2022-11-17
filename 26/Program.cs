// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

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

int n = 10;
int[,] array4 = new int[n, n];



for (int digit = 1, z = 0; z < n / 2; z++)
{

    for (int i = z; i < n - z; i++)
    {
        array4[z, i] = digit;
        digit++;
    }

    for (int i = z + 1; i < n - z; i++)
    {
        array4[i, n - z - 1] = digit;
        digit++;
    }

    for (int i = z + 1; i < n - z; i++)
    {
        array4[n - z - 1, n - i - 1] = digit;
        digit++;
    }
    for (int i = z + 2; i < n - z; i++)
    {
        array4[n - i, z] = digit;
        digit++;
    }

    if (n % 2 != 0 && array4[0, 0] == 1)
        array4[n / 2, n / 2] = digit;


}



Console.WriteLine();
Print2Array(array4);
Console.WriteLine();