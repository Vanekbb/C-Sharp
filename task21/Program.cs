/*

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53

*/

Console.WriteLine("Введите координаты точки a по оси x:");
int ax = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки a по оси y:");
int ay = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки a по оси z:");
int az = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки a по оси x:");
int bx = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки a по оси y:");
int by = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки a по оси z:");
int bz = Convert.ToInt32(Console.ReadLine());

double distans = Math.Sqrt(Math.Pow((bx - ax), 2) + Math.Pow((ay - by), 2) + Math.Pow((bz - az), 2));
Console.WriteLine(distans);