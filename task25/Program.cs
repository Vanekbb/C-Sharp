﻿/*

Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16

*/

Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int result = numberA;

for (int i = 1; i < numberB; i++) {
    result = result * numberA;
}

Console.WriteLine(result);
//Console.WriteLine(Math.Pow(numberA, numberB));