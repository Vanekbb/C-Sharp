/*

 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

*/

Console.WriteLine("Введите координаты точки a по оси x:");
int ax = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки a по оси y:");
int ay = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки a по оси x:");
int bx = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки a по оси y:");
int by = Convert.ToInt32(Console.ReadLine());

double distans = Math.Sqrt(Math.Pow((bx - ax), 2) + Math.Pow((ay - by), 2));
Console.WriteLine(distans);