// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и 
// возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

void PrintPozition(int x, int y, int[,] matrix)
{
if (x > matrix.GetLength(0)-1 || y > matrix.GetLength(1)-1)
{
     Console.WriteLine("Такого элемента нет");
}
else
{
Console.WriteLine("Значение элемента на заданной позиции: " + matrix[x,y]);
}
}

void Fill2Array(int[,] matrix)
{
    Random random = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = random.Next(-100, 100);

        }
    }
}

int[,] mat = new int[5,8];
Fill2Array(mat);
Console.WriteLine("Введите позицию элементов массива:");
int xpozition = Convert.ToInt32(Console.ReadLine());
int ypozition = Convert.ToInt32(Console.ReadLine());
PrintPozition(xpozition, ypozition, mat);
