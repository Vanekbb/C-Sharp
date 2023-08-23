/*

Напишите программу, которая на вход принимает число (N) и выдает таблицу квадратов числе от 1 до N.

*/

Console.WriteLine("Введите число:");
int userNumber = Convert.ToInt32(Console.ReadLine());

double result = 0;

if (userNumber < 0) {
    userNumber = userNumber * -1;
}

for (int i = 1; i <= userNumber; i++) {
    result = Math.Pow(i, 2);
    Console.WriteLine(result);
}