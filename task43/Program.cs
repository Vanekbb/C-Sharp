/*

Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

*/

Console.Write("Укажите значение b1: ");
double userNumberB1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Укажите значение b2: ");
double userNumberB2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Укажите значение k1: ");
double userNumberK1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Укажите значение k2: ");
double userNumberK2 = Convert.ToDouble(Console.ReadLine());

void Coordinates(double b1, double k1, double b2, double k2) {
    double x = ( b2 - b1 ) / ( k1 - k2 );
    double y = k1 * x + b1;
    Console.Write($"Точка пересечения двух прямых ({x}; {y})");
}

Coordinates(userNumberB1, userNumberK1, userNumberB2, userNumberK2);