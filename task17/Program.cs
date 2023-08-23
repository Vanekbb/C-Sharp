/*

Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

*/

int userNumberX = 0;
int userNumberY = 0;

while (userNumberX == 0) {
    Console.WriteLine("Введите число X, не равное 0:");
    userNumberX = Convert.ToInt32(Console.ReadLine());
}

while (userNumberY == 0) {
    Console.WriteLine("Введите число Y, не равное 0:");
    userNumberY = Convert.ToInt32(Console.ReadLine());
}

if (userNumberX < 0 && userNumberY > 0) {
    Console.WriteLine("II четверть");
} else if (userNumberX > 0 && userNumberY > 0) {
    Console.WriteLine("I четверть");
} else if (userNumberX < 0 && userNumberY < 0) {
    Console.WriteLine("III четверть");
} else if (userNumberX > 0 && userNumberY < 0) {
    Console.WriteLine("IV четверть");
}