/*

Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30

*/

void FindSum(int m, int n, int result = 0) {
    if (n >= m) {
        FindSum(m + 1, n, result + m);
    } else {
        Console.WriteLine(result);
    }
}

FindSum(1, 15);