﻿/*

Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29

*/

int Acr(int n, int m) {
    if (n == 0) {
        return m + 1;
    } else if (m == 0) {
        return Acr(n - 1, 1);
    } else {
        return Acr(n - 1, Acr(n, m -1));
    }
}

int result = Acr(3, 2);
Console.Write(result);