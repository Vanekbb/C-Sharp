/*

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да

*/

int userNumber = 0;
int remains = 0;
int reversNumber = 0;

while (userNumber < 10000 || userNumber > 100000) {
    Console.Write("Введите пятизначное число: ");
    userNumber = Convert.ToInt32(Console.ReadLine());
}

int temporaryNumber = userNumber;

while (temporaryNumber > 0) {
    remains = temporaryNumber % 10;
    temporaryNumber = temporaryNumber / 10;
    reversNumber = (reversNumber * 10) + remains;
}

if (reversNumber == userNumber) {
    Console.WriteLine("Число является палиндромом");
} else {
    Console.WriteLine("Число не является палиндромом");
}