// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// 
// [3 7 22 2 78] -> 76

Console.WriteLine("");
Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array123 = new double[n];
Random random = new Random();
double raznica = 0;
Console.Write("Выводим массив: ");


for (int i = 0; i < n; i++)
{
    array123[i] = random.Next(1, 99);
    Console.Write($" {array123[i]}");
}

double min = array123[0];
double max = array123[0];

for (int i = 0; i < n; i++)
{
    if (max < array123[i])
    {
        max = array123[i];

    }

    if (min > array123[i])
    {
        min = array123[i];

    }
}

raznica = max - min;
Console.WriteLine("");
Console.Write("Разница между максимальным и минимальным элементами массива: ");
Console.WriteLine(raznica);
Console.WriteLine("");
