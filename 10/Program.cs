// * Задача 21
//
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//
//A (3,6,8); B (2,1,-7), -> 15.84
//
//A (7,-5, 0); B (1,-1,9) -> 11.53
// формула:
// AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2

double rezult = 0;
 
Console.WriteLine("Введите координаты первой точки:");

double xa = Convert.ToInt32(Console.ReadLine());
double ya = Convert.ToInt32(Console.ReadLine());
double za = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки:");

double xb = Convert.ToInt32(Console.ReadLine());
double yb = Convert.ToInt32(Console.ReadLine());
double zb = Convert.ToInt32(Console.ReadLine());
 
rezult = Math.Sqrt((xb-xa)*(xb-xa)+(yb-ya)*(yb-ya)+(zb-za)*(zb-za));

Console.WriteLine(rezult);
