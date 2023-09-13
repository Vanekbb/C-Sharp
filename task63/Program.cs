/*

Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

*/

void NaturalNum(int n, int start = 1) {
    if (start <= n) {
        Console.Write($"{start} ");
        NaturalNum(n, start + 1);
    }
}

NaturalNum(5);