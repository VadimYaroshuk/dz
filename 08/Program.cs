// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


void Polindrom()
{
    Console.Write("Введите пятизначное число: ");
    string digit = Console.ReadLine();

    if (digit[0] == digit[4] && digit[1] == digit[3])
    {
        Console.WriteLine(digit + "- это число является полиндромом");
    }
    else
    {
        Console.WriteLine(digit + " - это число не является полиндромом");
    }
}
Polindrom();
