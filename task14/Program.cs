/*

Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

14 -> нет
46 -> нет
161 -> да

*/

Console.WriteLine("Введите число:");
int userNumber = Convert.ToInt32(Console.ReadLine());

int numberOne = 7;
int numberTwo = 23;

if (userNumber % (numberOne * numberTwo) == 0) {
    Console.WriteLine($"Число {userNumber} - кратно {numberOne} и {numberTwo}.");
} else {
    Console.WriteLine($"Число {userNumber} - не кратно {numberOne} и {numberTwo}.");
};