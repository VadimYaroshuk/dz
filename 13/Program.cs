// Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран.

// N = 5, получаем массив [1, 2, 5, 7, 19]

// N = 3, получаем массив [6, 1, 33]


void GoodArray(int n)
{
    int[] Array = new int[n];

    for (int i = 0; i < n; i++)
    {
        Random random = new Random();
        int a;
        a = random.Next(100);
        Array[i] = a;
        Console.Write(" ");
        Console.Write(Array[i]);
    }

}

Console.Write("Задайте размер массива: ");

int SizeArray = Convert.ToInt32(Console.ReadLine());

GoodArray(SizeArray);



