/*

Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

*/

int userNumber = 0;

while (userNumber < 1 || userNumber >= 5) {
    Console.WriteLine("Введите номер четверти (от 1 до 4):");
    userNumber = Convert.ToInt32(Console.ReadLine());
}

switch (userNumber) {
    case 1:
    Console.WriteLine("От X > 0 и Y > 0");
    break;
    case 2:
    Console.WriteLine("От X < 0 и Y > 0");
    break;
    case 3:
    Console.WriteLine("От X < 0 и Y < 0");
    break;
    case 4:
    Console.WriteLine("От X > 0 и Y < 0");
    break;
};