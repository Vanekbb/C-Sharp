/*

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125

*/

Console.Write("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

double result = 0;

if (userNumber < 0) {
    userNumber = userNumber * -1;
}

for (int i = 1; i <= userNumber; i++) {
    result = Math.Pow(i, 3);
    Console.WriteLine(result);
}