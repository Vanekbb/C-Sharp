/*

Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

*/

int FindSumNumbers(int n) {
    if (n > 0) {
        return n % 10 + FindSumNumbers(n / 10);
    } else {
        return n;
    }
}

int result = FindSumNumbers(999);
Console.WriteLine(result);