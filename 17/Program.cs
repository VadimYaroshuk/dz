// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

Console.WriteLine("");
Console.Write("Введите размер массива: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] A = new int[m];
int count = 0;

for (int i = 0; i < m; i++)
{
    Console.Write("Введите " + i + " элемент массива: ");
    A[i] = Convert.ToInt32(Console.ReadLine());

    if (A[i] > 0)
    {
        count++;
    }
}
Console.WriteLine("Количество элементов массива больше 0:  " + count);
Console.WriteLine("");
