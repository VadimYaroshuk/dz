// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

Console.WriteLine("");
Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array123 = new int[n];
Random random = new Random();
int sum = 0;
Console.Write("Выводим массив: ");
for (int i = 0; i < n; i++)
{
    array123[i] = random.Next(-99, 99);
    Console.Write($" {array123[i]}");

    if (i % 2 != 0)
    {
        sum = sum + array123[i];
    }

}
// for (int j = 1; j < n; j = j + 2)
// {
//     sum = sum + array123[j];
// }

Console.WriteLine("");
Console.Write("Сумма элементов массива, стоящих на нечетных позициях: ");
Console.WriteLine(sum);
Console.WriteLine("");




