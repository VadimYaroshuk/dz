// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452-> 11

// 82-> 10

//  9012-> 12


Console.Write("Введите число: ");
string str = Console.ReadLine();
int x = str.Length;
int sum = 0;

for (int i = 0; i < x - 1; i++)

{ 
   int y = Convert.ToInt32(str[i]);
    sum = sum + y; }

Console.Write(sum);

