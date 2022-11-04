// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
//  которая покажет количество чётных чисел в массиве.

//  [345, 897, 568, 234] -> 2


Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array123 = new int[n];
Random random = new Random();
int count = 0;
Console.Write("Выводим массив: ");
for (int i = 0; i < n; i++)
{
    array123[i] = random.Next(100, 999);
    Console.Write($" {array123[i]}");

    if (array123[i] % 2 == 0)
    {
        count++;
    }

}
Console.WriteLine("");
Console.Write("Количество четных элементов массива: ");
Console.WriteLine(count);

