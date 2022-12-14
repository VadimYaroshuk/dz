// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

void Fill2Array(double[,] matrix)
{
    Random rand = new Random(DateTime.Now.Millisecond);
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.NextDouble()*10;
        }
    }
}

void Print2Arrya(double[,] matrix2)
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

Console.WriteLine("Введите размерность массива:");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[m, n];
Fill2Array(array);
Print2Arrya(array);
