/*

Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

*/

void NaturalNums(int m, int n) {
    if (n >= m) {
        Console.Write($"{m} ");
        NaturalNums(m + 1, n);
    }
}

NaturalNums(1, 7);